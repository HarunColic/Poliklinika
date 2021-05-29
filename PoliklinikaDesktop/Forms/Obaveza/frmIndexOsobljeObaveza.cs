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

        private void dgvAktivne_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
