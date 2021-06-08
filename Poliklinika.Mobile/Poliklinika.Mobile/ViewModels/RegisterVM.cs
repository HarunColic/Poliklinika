using Poliklinika.Mobile.Views;
using Poliklinika.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;
using Xamarin.Forms;

namespace Poliklinika.Mobile.ViewModels
{
    public class RegisterVM : BaseViewModel
    {
        public Command RegisterCommand { get; }
        private readonly APIService _korisnik = new APIService("Korisnik");
        private readonly APIService _service = new APIService("Authentication");
        
        string _username = string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }
        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }


        public RegisterVM()
        {
            RegisterCommand = new Command(OnRegisterClicked);
        }

        private async void OnRegisterClicked(object obj)
        {
            var req = new request
            {
                email = this.Username,
                password = this.Password
            };

            var signup = await _korisnik.Insert<response>(req);

            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        }

        public class request
        {
            public string email { get; set; }
            public string password { get; set; }
        }

        public class response
        {
            public int ID { get; set; }
            public string Ime { get; set; }
            public string Prezime { get; set; }
            public string Spol { get; set; }
            public string Email { get; set; }
            public string BrojTelefona { get; set; }
            public DateTime DatumRodjenja { get; set; }
            public string KrvnaGrupa { get; set; }
        }
    }
}
