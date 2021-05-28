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
    public partial class frmDetaljiIzvjestaj : Form
    {
        private readonly APIService _service = new APIService("Izvjestaj");
        private readonly APIService _pregled = new APIService("Pregled");
        private readonly APIService _korisnik = new APIService("Korisnik");
        private readonly APIService _doktor = new APIService("Doktor");
        private readonly APIService _odjel = new APIService("Odjel");
        private readonly int? _id;
        public frmDetaljiIzvjestaj(int izvjestajid)
        {
            InitializeComponent();
            _id = izvjestajid;
        }
        IzvjestajVM request = new IzvjestajVM();
        private async void frmDetaljiIzvjestaj_Load(object sender, EventArgs e)
        {
            var check = await isPregled(_id);
            if (check)
            {
                var prid = await _pregled.GetById<PregledVM>(_id);
                var korisnik = await _korisnik.GetById<KorisnikVM>(prid.KorisnikID);
                var doktor = await _doktor.GetById<DoktorVM>(prid.DoktorID);
                var odjel = await _odjel.GetById<OdjelVM>(doktor.OdjelID);

                lblDoktor.Text= $"{doktor.Ime} {doktor.Prezime}";
                lblKorisnik.Text = $"{korisnik.Ime} {korisnik.Prezime}";
                lblDatum.Text = prid.Datum.ToString();
                lblOdjel.Text = odjel.Naziv;
                lblOpisPregled.Text = prid.Opis;
                txtpregledID.Text = prid.ID.ToString();


            }
            else if (_id.HasValue)
            {
                var izvjestaj = await _service.GetById<IzvjestajVM>(_id);
                var Prid = await _pregled.GetById<PregledVM>(izvjestaj.PregledID);
                var korisnik = await _korisnik.GetById<KorisnikVM>(Prid.KorisnikID);
                var doktor = await _doktor.GetById<DoktorVM>(Prid.DoktorID);
                var odjel = await _odjel.GetById<OdjelVM>(doktor.OdjelID);

                lblDoktor.Text = $"{doktor.Ime} {doktor.Prezime}";
                lblKorisnik.Text = $"{korisnik.Ime} { korisnik.Prezime}";
                lblDatum.Text = Prid.Datum.ToString();
                lblOdjel.Text = odjel.Naziv;
                lblOpisPregled.Text = Prid.Opis;
                txtOpisIzvjestaja.Text = izvjestaj.Opis;


            }
        }

        private async Task<bool> isPregled(int? id)
        {
            var IzvLista = await _service.Get<List<IzvjestajVM>>(null);

            foreach (var i in IzvLista)
            {
                if (i.PregledID == id)
                    return false;
            }
            return true;
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            request.Opis = txtOpisIzvjestaja.Text;

            var check = await isPregled(_id);

            if (check)
            {
                request.PregledID = int.Parse(txtpregledID.Text);
                await _service.Insert<IzvjestajVM>(request);
            }
            else
            {
                var izv = await _service.GetById<IzvjestajVM>(_id);
                izv.Opis = txtOpisIzvjestaja.Text;

                await _service.Update<IzvjestajVM>(izv);
            }

        }
    }
}
