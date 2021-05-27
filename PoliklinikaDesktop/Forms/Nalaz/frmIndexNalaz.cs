using PoliklinikaAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PoliklinikaDesktop.Forms.Nalaz
{
    public partial class frmIndexNalaz : Form
    {
        private readonly APIService _service = new APIService("Nalaz");
        private readonly APIService _pregled = new APIService("Pregled");
        private readonly APIService _korisnik = new APIService("Korisnik");

        public frmIndexNalaz()
        {
            InitializeComponent();
        }

        private async void frmIndexNalaz_Load(object sender, EventArgs e)
        {
            var id = CurrentUser.User.Id;

            var result = await _pregled.Get<List<PregledVM>>(new PregledVM()
            {
                DoktorID = id,
                Opis = "Nalaz"
            });
            dgvPregled.AutoGenerateColumns = false;
            dgvPregled.DataSource = result;
            if (result != null)
            {

                //for (int i = 0; i < dgvPregled.RowCount - 1; i++)
                foreach(DataGridViewRow i in dgvPregled.Rows)
                {
                    var prid = await _pregled.GetById<PregledVM>(result[i.Index].ID);
                    var korisnik = await _korisnik.GetById<KorisnikVM>(prid.KorisnikID);
                    i.Cells[1].Value = korisnik.Prezime;
                    i.Cells[2].Value = korisnik.Ime;

                    //dgvPregled.Rows[i].Cells[1].Value = korisnik.Prezime;
                    //dgvPregled.Rows[i].Cells[2].Value = korisnik.Ime;
                } 
            }
            var result2 = await _service.Get<List<NalazVM>>(new PregledVM()
            {
                DoktorID = id
            });

            dgvNalaz.DataSource = result2;
        }

        private void dgvPregled_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = dgvPregled.CurrentCell.ColumnIndex;
            if (columnIndex == 3)
            {
                var id = dgvPregled.CurrentRow.Cells[0].Value;
                frmDetaljiNalaz detalji = new frmDetaljiNalaz(int.Parse(id.ToString()));
                detalji.Show();
            }
        }
    }
}
