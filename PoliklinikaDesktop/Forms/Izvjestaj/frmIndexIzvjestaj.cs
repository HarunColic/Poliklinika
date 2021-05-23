using PoliklinikaAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoliklinikaDesktop.Forms.Izvjestaj
{
    public partial class frmIndexIzvjestaj : Form
    {
        private readonly APIService _zaposleni = new APIService("Doktor");
        private readonly APIService _odjel = new APIService("Odjel");
        private readonly APIService _izvjestaj = new APIService("Izvjestaj");
        public frmIndexIzvjestaj()
        {
            InitializeComponent();
        }
        private async Task LoadZaposleni()
        {
            var result = await _zaposleni.Get<IList<DoktorVM>>();
            result.Insert(0, new DoktorVM());
            cmbZaposlenik.DisplayMember = "Ime";
            cmbZaposlenik.ValueMember = "ID";
            cmbZaposlenik.DataSource = result;
        }
        private async Task LoadOdjel()
        {
            var result = await _odjel.Get<List<Poliklinika.Model.Odjel>>();
            result.Insert(0, new Poliklinika.Model.Odjel());
            cmbOdjel.DisplayMember = "Naziv";
            cmbOdjel.ValueMember = "ID";
            cmbOdjel.DataSource = result;

        }

        private async void frmIndexIzvjestaj_Load(object sender, EventArgs e)
        {
            await LoadZaposleni();
            await LoadOdjel();
        }

        private void cmbZaposlenik_Format(object sender, ListControlConvertEventArgs e)
        {
            
            string ime = ((DoktorVM)e.ListItem).Ime;
            string prezime = ((DoktorVM)e.ListItem).Prezime;
            e.Value = ime + " " + prezime;

        }

        private void cmbZaposlenik_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbZaposlenik.SelectedValue;
        }
        //private Task LoadIzvjestaj(int zaposlenikID)
        //{
        //    var result = _izvjestaj.Get<List<IzvjestajVM>);
        //}
    }
}
