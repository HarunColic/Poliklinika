using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Poliklinika.Mobile.ViewModels
{
    public class KorisnikPregled : BaseViewModel
    {
        private readonly APIService _pregled = new APIService("Pregled");
        public KorisnikPregled()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ObservableCollection<PreglediVM> PreglediLista { get; set; } = new ObservableCollection<PreglediVM>();
        public ICommand InitCommand { get; }


        public async Task Init()
        {

            var list = await _pregled.Get<IEnumerable<PreglediVM>>(null);
            PreglediLista.Clear();

            foreach (var pregledi in list)
            {
                if(pregledi.KorisnikID==CurrentUser.User.Id)
                PreglediLista.Add(pregledi);
            }
        }
        public class PreglediVM
        {
            public int KorisnikID { get; set; }
            public DateTime Datum { get; set; }
            public int OdjelID { get; set; }
        }
    }
}
