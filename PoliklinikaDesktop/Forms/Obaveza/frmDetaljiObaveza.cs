using PoliklinikaAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoliklinikaDesktop.Forms.Obaveza
{
    public partial class frmDetaljiObaveza : Form
    {
        private readonly APIService _odjel = new APIService("Odjel");
        private readonly APIService _osoblje = new APIService("Osoblje");
        private readonly APIService _service = new APIService("Obaveza");
        private int? _id = null;
        public frmDetaljiObaveza(int? odjelid = null)
        {
            InitializeComponent();
            _id = odjelid;
        }


        private async void frmDetaljiObaveza_Load(object sender, EventArgs e)
        {
            await LoadOdjel();
            await LoadZaposleni();
        }

        ObavezaVM request = new ObavezaVM();
        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            request.Opis = txtOpis.Text;
            request.Datum = dtpDatum.Value;
            request.Aktivna = true;

            if (_id.HasValue)
            {
                var obaveza = await _service.GetById<ObavezaVM>(_id);

                obaveza.Opis = txtOpis.Text;
                obaveza.Datum = dtpDatum.Value;


                await _service.Update<ObavezaVM>(request);
            }
            else
            {
                await _service.Insert<ObavezaVM>(request);
            }

        }
        private async Task LoadOdjel()
        {
            var result = await _odjel.Get<List<Poliklinika.Model.Odjel>>(null);
            result.Insert(0, new Poliklinika.Model.Odjel());
            cmbOdjel.DisplayMember = "Naziv";
            cmbOdjel.ValueMember = "ID";
            cmbOdjel.DataSource = result;

        }
        private async Task LoadZaposleni()
        {
            var result = await _osoblje.Get<List<OsobljeVM>>(null);
            result.Insert(0, new OsobljeVM());
            cmbZaposlenik.DisplayMember = "Ime";
            cmbZaposlenik.ValueMember = "ID";
            cmbZaposlenik.DataSource = result;
        }

        private void cmbZaposlenik_Format(object sender, ListControlConvertEventArgs e)
        {
            string ime = ((OsobljeVM)e.ListItem).Ime;
            string prezime = ((OsobljeVM)e.ListItem).Prezime;
            e.Value = ime + " " + prezime;
        }

        private void cmbZaposlenik_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbZaposlenik.SelectedValue;

            if (int.TryParse(idObj.ToString(), out int osobID))
            {
                request.OsobljeID = osobID;
            }
        }

        private void cmbOdjel_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbOdjel.SelectedValue;

            if (int.TryParse(idObj.ToString(), out int odjelID))
            {
                request.OdjelID = odjelID;
            }
        }
    }
}
