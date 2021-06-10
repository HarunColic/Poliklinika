using Poliklinika.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Poliklinika.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OdabirTerminaPage : ContentPage
    {
        private readonly int _odjelID;
        private readonly APIService _odjel = new APIService("Odjel");
        ItemsViewModel.OdjelVM odjel;
        PregledVM model = null;

        public OdabirTerminaPage(int OdjelID)
        {
            _odjelID = OdjelID;
            BindingContext  = model = new PregledVM(OdjelID);

            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            odjel = await _odjel.GetById<ItemsViewModel.OdjelVM>(_odjelID);

            naziv.Text = odjel.Naziv;
            slika.Source = ImageSource.FromStream(() => new MemoryStream(odjel.Slika));
            OdjelID.Text = _odjelID.ToString();

            base.OnAppearing();
        }
    }
}