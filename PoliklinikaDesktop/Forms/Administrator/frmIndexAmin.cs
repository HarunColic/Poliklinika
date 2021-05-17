using PoliklinikaDesktop.Forms.Odjel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PoliklinikaDesktop.Forms.Administrator
{
    public partial class frmIndexAmin : Form
    {
        public frmIndexAmin()
        {
            InitializeComponent();
        }

        private void picEvidOdjela_Click(object sender, EventArgs e)
        {
            frmIndexOdjel index = new frmIndexOdjel();
            index.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmOdabirZaposlenog zaposleni = new frmOdabirZaposlenog();
            zaposleni.Show();
        }
    }
}
