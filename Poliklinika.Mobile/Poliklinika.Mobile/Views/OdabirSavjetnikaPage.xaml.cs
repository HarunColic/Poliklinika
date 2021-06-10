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
    public partial class OdabirSavjetnikaPage : ContentPage
    {
        private readonly int _odjelID;
        private readonly APIService _odjel = new APIService("Odjel");
        private readonly APIService _doktori = new APIService("Doktor");
        public OdabirSavjetnikaPage(int OdjelID)
        {
            _odjelID = OdjelID;
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            var doktori = await _doktori.Get<List<DoktorVM>>(null);
            var lista = doktori.Where(x => x.OdjelID == _odjelID).ToList();
            picker.ItemsSource = lista;

            base.OnAppearing();
        }
        public class DoktorVM
        {
            public int ID { get; set; }
            public string Ime { get; set; }
            public string Prezime { get; set; }
            public int OdjelID { get; set; }
        }
    }
}