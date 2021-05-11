using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Flurl.Http;
using Flurl;
using PoliklinikaAPI.ViewModels;

namespace PoliklinikaDesktop.Forms.Odjel
{
   
    public partial class frmIndexOdjel : Form
    {
        private readonly APIService _apiService = new APIService("Odjel");
        public frmIndexOdjel()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private async void frmIndexOdjel_Load(object sender, EventArgs e)
        {
            var result = await _apiService.Get<List<Poliklinika.Model.Odjel>>();
            dgvOdjeli.AutoGenerateColumns = false;
            dgvOdjeli.DataSource = result;
        }

     
        private void dgvOdjeli_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = dgvOdjeli.CurrentCell.ColumnIndex;
            if (columnIndex == 2)
            {
                var id = dgvOdjeli.SelectedRows[0].Cells[0].Value;
                frmDetaljiOdjel detalji = new frmDetaljiOdjel(int.Parse(id.ToString()));
                detalji.Show();
            }
           
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmDetaljiOdjel odjel = new frmDetaljiOdjel();
            odjel.Show();
        }
    }
}
