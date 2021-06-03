using Poliklinika.Mobile.ViewModels;
using Poliklinika.Mobile.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Poliklinika.Mobile
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(Register), typeof(Register));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }

        private async void Register_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//Register");
        }

        private async void Logout_Clicked(object sender, EventArgs e)
        {
            CurrentUser.User = null;
            CurrentUser.JWT = null;

            await Shell.Current.GoToAsync("//AboutPage");
        }
    }
}
