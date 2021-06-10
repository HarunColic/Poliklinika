﻿using Poliklinika.Mobile.ViewModels;
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
    public partial class PrikazPregledaPage : ContentPage
    {
        private KorisnikPregled model = null;
        public PrikazPregledaPage()
        {
            InitializeComponent();
            BindingContext = model = new KorisnikPregled();
        }
        protected override async void OnAppearing()
        {
            await model.Init();
            base.OnAppearing();

        }
    }
}