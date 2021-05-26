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

            dgvPregled.DataSource = result;

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
