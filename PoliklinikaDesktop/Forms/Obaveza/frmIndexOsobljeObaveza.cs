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
    public partial class frmIndexOsobljeObaveza : Form
    {
        private readonly APIService _service = new APIService("Obaveza");
        private readonly APIService _admin = new APIService("Admin");
        private readonly APIService _chatObaveza = new APIService("ChatObaveza");


        public frmIndexOsobljeObaveza()
        {
            InitializeComponent();
        }

        private async void frmIndexOsobljeObaveza_Load(object sender, EventArgs e)
        {
            var id = CurrentUser.User.Id;

            var result = await _service.Get<List<ObavezaVM>>(new ObavezaVM()
            {
                OsobljeID = id,
                Aktivna = true
            });

            var result2 = await _service.Get<List<ObavezaVM>>(new ObavezaVM()
            {
                OsobljeID = id,
                Aktivna = false
            });

            dgvIzvrsene.AutoGenerateColumns = false;
            dgvAktivne.AutoGenerateColumns = false;
            dgvAktivne.DataSource = result;
            dgvIzvrsene.DataSource = result2;
        }

        private async void dgvAktivne_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = dgvAktivne.CurrentCell.ColumnIndex;
            if (columnIndex == 3)
            {
                var id = int.Parse(dgvAktivne.CurrentRow.Cells[0].Value.ToString());
                
                frmDetaljiOsobljeObaveza detalji = new frmDetaljiOsobljeObaveza(id);
                detalji.Show();
            }
        }
    }
}
