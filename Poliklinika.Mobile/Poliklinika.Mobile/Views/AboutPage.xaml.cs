using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Poliklinika.Mobile.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private void UserLogedIn()
        {
            if (CurrentUser.User != null && CurrentUser.JWT != null)
            {
                
            }
        }
    }
}