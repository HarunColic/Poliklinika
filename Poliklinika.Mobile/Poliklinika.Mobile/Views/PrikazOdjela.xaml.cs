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
    public partial class PrikazOdjela : ContentPage
    {
        private readonly APIService _odjel = new APIService("Odjel");
        int _id;
        public PrikazOdjela(int id)
        {
            _id = id;
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            var odjel = await _odjel.GetById<OdjelViewModel>(_id);

            naziv.Text = odjel.Naziv;
            opis.Text = odjel.Opis;

            base.OnAppearing();
        }
    }
}