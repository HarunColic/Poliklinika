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
            frmDetaljiOdjel detalji = new frmDetaljiOdjel();
           


        }

       
    }
}
