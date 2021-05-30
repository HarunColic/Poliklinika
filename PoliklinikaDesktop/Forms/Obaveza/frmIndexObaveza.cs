using PoliklinikaAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PoliklinikaDesktop.Forms.Obaveza
{
    public partial class frmIndexObaveza : Form
    {
        private readonly APIService _service = new APIService("Obaveza");
        public frmIndexObaveza()
        {
            InitializeComponent();
        }

        private async void frmIndexObaveza_Load(object sender, EventArgs e)
        {
            var request = await _service.Get<List<ObavezaVM>>(null);
            dgvObaveze.AutoGenerateColumns = false;
            dgvObaveze.DataSource = request;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmDetaljiObaveza obaveza = new frmDetaljiObaveza();
            obaveza.Show();
        }

        private void dgvObaveze_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = dgvObaveze.CurrentCell.ColumnIndex;
            if (columnIndex == 2)
            {
                var id = dgvObaveze.CurrentRow.Cells[0].Value;
                frmDetaljiObaveza detalji = new frmDetaljiObaveza(int.Parse(id.ToString()));
                detalji.Show();
            }
        }
    }
}
