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
    public partial class PlacanjePage : ContentPage
    {
        PregledVM.Pregled _pregled;
        public PlacanjePage(PregledVM.Pregled pregled)
        {
            InitializeComponent();
            _pregled = pregled;
        }

    }
}