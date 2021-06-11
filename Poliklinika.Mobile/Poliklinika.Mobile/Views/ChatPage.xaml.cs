using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Poliklinika.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChatPage : ContentPage
    {
        private readonly int _id;
        private readonly APIService _konsultacijePoruka = new APIService("KonsultacijePoruka");

        public ChatPage(int iD)
        {
            _id = iD;
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            var svePoruke = await _konsultacijePoruka.Get<List<response>>(null);
            var poruke = svePoruke.Where(x => x.KonsultacijeID == _id);

            foreach (var p in poruke) 
            {
                Container.Children.Add(new Label { Text = p.Poruka });
            }
            
            Container.Children.Add(new Entry { Placeholder = "Vasa poruka", AutomationId = "Entry" });
            var entry = (Entry)Container.Children.FirstOrDefault(x => x.AutomationId == "Entry");
            var resp = new response
            {
                KonsultacijeID = _id,
                Poruka = entry.Text,
                UserID = CurrentUser.User.Id
            };

            Container.Children.Add(new Button { Text = "Posalji",
                Command = new Command( async () =>
                {
                    await _konsultacijePoruka.Insert<response>(resp);
                })
            });
            base.OnAppearing();
        }

        public class response
        {
            public int UserID { get; set; }
            public int KonsultacijeID { get; set; }
            public string Poruka { get; set; }
        }
    }
}