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

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            var result = _apiService.Get<List<Poliklinika.Model.Odjel>>();
            ProbaNebitno.DataSource=result;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dgvOdjel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
