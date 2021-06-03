using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Poliklinika.Mobile.Views
{
    public partial class AboutPage : ContentPage
    {

        Button _login;
        Button _register;

        public AboutPage()
        {
            InitializeComponent();
            _login = Login;
            _register = Register;
        }

        protected override void OnAppearing()
        {
            if (CurrentUser.IsLogedIn())
            {
                (Shell.Current as AppShell)._profil.IsVisible = true;
                (Shell.Current as AppShell)._poruke.IsVisible = true;
                (Shell.Current as AppShell)._prijava.IsVisible = false;
                (Shell.Current as AppShell)._odjava.IsVisible = true;
                (Shell.Current as AppShell)._register.IsVisible = false;
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
                _login.IsVisible = true;
                _register.IsVisible = true;
            }

            base.OnAppearing();
        }
    }
}