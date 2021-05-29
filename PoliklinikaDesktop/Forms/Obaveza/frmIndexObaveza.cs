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
            var request = await _service.Get<List<ObavezaVM>>(new ObavezaVM {
                Aktivna=true
            });
            var request2 = await _service.Get<List<ObavezaVM>>(new ObavezaVM
            {
                Aktivna = false
            });

            dgvObaveze.AutoGenerateColumns = false;
            dgvAktivne.AutoGenerateColumns = false;

            dgvAktivne.DataSource = request;
            dgvObaveze.DataSource = request2;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmDetaljiObaveza obaveza = new frmDetaljiObaveza();
            obaveza.Show();
        }

       

        private void dgvObaveze_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = dgvObaveze.CurrentCell.ColumnIndex;
            if (columnIndex == 3)
            {
                var id = dgvObaveze.CurrentRow.Cells[0].Value;
                frmDetaljiOsobljeObaveza detalji = new frmDetaljiOsobljeObaveza
                    (int.Parse(id.ToString()));
                detalji.Show();
            }
        }

        private async void dgvAktivne_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = dgvObaveze.CurrentCell.ColumnIndex;
            if (columnIndex == 3)
            {
                var id = dgvObaveze.CurrentRow.Cells[0].Value;
                frmDetaljiObaveza detalji = new frmDetaljiObaveza
                    (int.Parse(id.ToString()));
                detalji.Show();
            }
            else if(columnIndex == 4)
            {
                var id = dgvObaveze.CurrentRow.Cells[0].Value;
                await _service.Delete<object>(id);
            }
        }

       
    }
}
