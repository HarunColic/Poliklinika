using Poliklinika.Model;
using PoliklinikaAPI.ViewModels;
using PoliklinikaDesktop.Forms.Doktor;
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
        private readonly APIService _serviceDoktor = new APIService("Doktor");
        private readonly APIService _serviceTehnicar = new APIService("Tehnicar");
        public frmOdabirZaposlenog()
        {
            InitializeComponent();
        }

        private void picDodajDoktora_Click(object sender, EventArgs e)
        {
            frmDetaljiDoktor doktor = new frmDetaljiDoktor();
            doktor.Show();
        }

        private void frmOdabirZaposlenog_Load(object sender, EventArgs e)
        {
           var zaposlenici = _serviceDoktor.Get<IList<DoktorVM>>()
               + _serviceTehnicar.Get<IList<TehnicarVM>>();
        }
    }
}
