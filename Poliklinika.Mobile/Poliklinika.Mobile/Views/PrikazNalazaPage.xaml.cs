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
    public partial class PrikazNalazaPage : ContentPage
    {
        private readonly int _id;
        public PrikazNalazaPage(int id)
        {
            _id = id;
            InitializeComponent();
        }
    }
}