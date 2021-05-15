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
        public frmOdabirZaposlenog()
        {
            InitializeComponent();
        }

        private void picDodajDoktora_Click(object sender, EventArgs e)
        {
            frmDetaljiDoktor doktor = new frmDetaljiDoktor();
            doktor.Show();
        }
    }
}
