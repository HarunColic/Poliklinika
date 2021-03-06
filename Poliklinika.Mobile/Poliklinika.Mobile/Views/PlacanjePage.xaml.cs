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
    public partial class PlacanjePage : ContentPage
    {
        private PaymentVM model = null;
        private INavigation navigation;
        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
        KorisnikPregled.PreglediVM _pregled;

        public PlacanjePage(KorisnikPregled.PreglediVM pregled)
        {
            InitializeComponent();
            _pregled = pregled;
            var nav = new NavigationPage(new AboutPage());
            navigation = nav.Navigation;
            BindingContext = model = new PaymentVM(_pregled, navigation);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ErrorLabel_CardNumber.IsVisible = false;
            ErrorLabel_Cvv.IsVisible = false;
            ErrorLabel_Month.IsVisible = false;
            ErrorLabel_Year.IsVisible = false;
        }
        private void Number_changed(object sender, TextChangedEventArgs e)
        {
            if (Number.Text.Length > 16)
            {
                ErrorLabel_CardNumber.IsVisible = true;
                ErrorLabel_CardNumber.Text = "Credit card number must have 16 digits!";
            }
            else if (Number.Text.Length < 1)
            {
                ErrorLabel_CardNumber.IsVisible = true;
                ErrorLabel_CardNumber.Text = "This field is required!";
            }
            else
            {
                ErrorLabel_CardNumber.IsVisible = false;
            }
        }

        private void Number_unfocused(object sender, TextChangedEventArgs e)
        {
            if (Number.Text == null)
            {
                ErrorLabel_CardNumber.IsVisible = true;
                ErrorLabel_CardNumber.Text = "This field is required!";
            }
            else
            {
                ErrorLabel_CardNumber.IsVisible = false;
            }
        }

        private void Month_changed(object sender, TextChangedEventArgs e)
        {
            if (Month.Text.Length != 2)
            {
                ErrorLabel_Month.IsVisible = true;
                ErrorLabel_Month.Text = "This field required 2 digits!";
            }
            else if (Month.Text == null)
            {
                ErrorLabel_Month.IsVisible = true;
                ErrorLabel_Month.Text = "This field is required!";
            }
            else
            {
                ErrorLabel_Month.IsVisible = false;
            }
        }
        private void Month_unfocused(object sender, TextChangedEventArgs e)
        {
            if (Month.Text == null)
            {
                ErrorLabel_Month.IsVisible = true;
                ErrorLabel_Month.Text = "This field is required!";
            }
            else
            {
                ErrorLabel_Month.IsVisible = false;
            }
        }
        private void Year_changed(object sender, TextChangedEventArgs e)
        {
            if (Year.Text.Length != 2)
            {
                ErrorLabel_Year.IsVisible = true;
                ErrorLabel_Year.Text = "This field required 2 digits!";
            }
            else if (Year.Text == null)
            {
                ErrorLabel_Year.IsVisible = true;
                ErrorLabel_Year.Text = "This field is required!";
            }
            else
            {
                ErrorLabel_Year.IsVisible = false;
            }
        }
        private void Year_unfocused(object sender, TextChangedEventArgs e)
        {
            if (Year.Text == null)
            {
                ErrorLabel_Year.IsVisible = true;
                ErrorLabel_Year.Text = "This field is required!";
            }
            else
            {
                ErrorLabel_Year.IsVisible = false;
            }
        }

        private void Cvv_changed(object sender, TextChangedEventArgs e)
        {
            if (Cvv.Text.Length != 3)
            {
                ErrorLabel_Cvv.IsVisible = true;
                ErrorLabel_Cvv.Text = "This field require 3 digits!";
            }
            else if (Cvv.Text == null)
            {
                ErrorLabel_Cvv.IsVisible = true;
                ErrorLabel_Cvv.Text = "This field is required!";
            }
            else
            {
                ErrorLabel_Cvv.IsVisible = false;
            }
        }
        private void Cvv_unfocused(object sender, TextChangedEventArgs e)
        {
            if (Cvv.Text == null)
            {
                ErrorLabel_Cvv.IsVisible = true;
                ErrorLabel_Cvv.Text = "This field is required!";
            }
            else
            {
                ErrorLabel_Cvv.IsVisible = false;
            }
        }
    }
}