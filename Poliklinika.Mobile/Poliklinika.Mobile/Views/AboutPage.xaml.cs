using Poliklinika.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Poliklinika.Mobile.ViewModels.KorisnikPregled;

namespace Poliklinika.Mobile.Views
{
    public partial class AboutPage : ContentPage
    {

        Button _login;
        Button _register;
        private readonly APIService _pregled = new APIService("Pregled");
        public AboutPage()
        {
            InitializeComponent();
            _login = Login;
            _register = Register;
        }

        protected override async void OnAppearing()
        {
            if (CurrentUser.IsLogedIn())
            {
                (Shell.Current as AppShell)._profil.IsVisible = true;
                (Shell.Current as AppShell)._poruke.IsVisible = true;
                (Shell.Current as AppShell)._prijava.IsVisible = false;
                (Shell.Current as AppShell)._odjava.IsVisible = true;
                (Shell.Current as AppShell)._register.IsVisible = false;  
                (Shell.Current as AppShell)._pregledi.IsVisible = true;  
                _login.IsVisible = false;
                _register.IsVisible = false;
            }
            else
            {
                (Shell.Current as AppShell)._profil.IsVisible = false;
                (Shell.Current as AppShell)._poruke.IsVisible = false;
                (Shell.Current as AppShell)._prijava.IsVisible = true;
                (Shell.Current as AppShell)._odjava.IsVisible = false;
                (Shell.Current as AppShell)._register.IsVisible = true;
                (Shell.Current as AppShell)._pregledi.IsVisible = false;
                _login.IsVisible = true;
                _register.IsVisible = true;
            }
            if (CurrentUser.IsLogedIn())
            {
                TrenutniKorisnik trenutni = new TrenutniKorisnik
                {
                    korisnikID = CurrentUser.User.Id
                };
                preporukeView.IsVisible = true;
                var pregledi = await _pregled.Get<List<KorisnikPregled.TrenutniKorisnik>>(trenutni);
                
                if (pregledi.Count() == 0 && string.IsNullOrEmpty(CurrentUser.User.Spol))
                {
                    preporukeView.IsVisible = false;
                }
                List<int> odjeliID = new List<int>();


            }
            else
                preporukeView.IsVisible = false;

            base.OnAppearing();
        }
    }
}