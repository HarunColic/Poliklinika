using Poliklinika.Model;
using PoliklinikaAPI.ViewModels;
using PoliklinikaDesktop.Forms.Doktor;
using PoliklinikaDesktop.Forms.Tehnicar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PoliklinikaDesktop.Forms.Administrator
{
    public partial class frmOdabirZaposlenog : Form
    {
        private readonly APIService _service = new APIService("Osoblje");
        public frmOdabirZaposlenog()
        {
            InitializeComponent();
        }

        private void picDodajDoktora_Click(object sender, EventArgs e)
        {
            frmDetaljiDoktor doktor = new frmDetaljiDoktor();
            doktor.Show();
        }

        private void picDodajTehnicara_Click(object sender, EventArgs e)
        {
            frmDetaljiTehnicar doktor = new frmDetaljiTehnicar();
            doktor.Show();
        }
        private void frmOdabirZaposlenog_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
            var zaposlenici = _service.Get<List<OsobljeVM>>();
=======
           
>>>>>>> master
        }

       
    }
}
