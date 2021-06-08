using Poliklinika.Mobile.ViewModels;
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
    public partial class Profil : ContentPage
    {
        private readonly APIService _korisnik = new APIService("Korisnik");

        public Profil()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            var user = await _korisnik.GetById<RegisterVM.response>(CurrentUser.User.Id);

            Ime.Text = user.Ime;
            Prezime.Text = user.Prezime;
            Email.Text = user.Email;
            Spol.Text = user.Spol;
            KrvnaGrupa.Text = user.KrvnaGrupa;
            BrojTelefon.Text = user.BrojTelefona;
            DatumRodjenja.Date = user.DatumRodjenja;

            base.OnAppearing();
        }
    }
}