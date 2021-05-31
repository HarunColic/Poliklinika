using PoliklinikaAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoliklinikaDesktop.Forms.Raspored
{
    public partial class frmDetaljiRaspored : Form
    {
        private readonly int? _id;
        private readonly APIService _pregled = new APIService("Pregled");
        private readonly APIService _osoblje = new APIService("Osoblje");
        public frmDetaljiRaspored(int? rasporedid)
        {
            InitializeComponent();
            _id = rasporedid;
        }
        PregledVM pregled = new PregledVM();
        RasporedVM raspored = new RasporedVM();
        private async void frmDetaljiRaspored_Load(object sender, EventArgs e)
        {
            await LoadZaposleni();

            if (_id.HasValue)
            {
                pregled = await _pregled.GetById<PregledVM>(_id);
                lblDatum.Text = pregled.Datum.ToString();
                
            }
            dtpKraj.Format = DateTimePickerFormat.Custom;
            dtpKraj.CustomFormat = "HH:mm";
        }
        private async Task LoadZaposleni()
        {
            var result = await _osoblje.Get<List<OsobljeVM>>(null);
            result.Insert(0, new OsobljeVM());
            cmbOsoblje.DisplayMember = "Ime";
            cmbOsoblje.ValueMember = "ID";
            cmbOsoblje.DataSource = result;
        }

        private void cmbOsoblje_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbOsoblje.SelectedValue;

            if (int.TryParse(idObj.ToString(), out int osobID))
            {
                raspored.OsobljeID = osobID;
            }
        }

        private void cmbOsoblje_Format(object sender, ListControlConvertEventArgs e)
        {
            string ime = ((OsobljeVM)e.ListItem).Ime;
            string prezime = ((OsobljeVM)e.ListItem).Prezime;
            e.Value = ime + " " + prezime;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {

        }
    }
}
