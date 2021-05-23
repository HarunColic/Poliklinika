﻿using PoliklinikaDesktop.Forms.Izvjestaj;
using PoliklinikaDesktop.Forms.Obaveza;
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

        private void picPregledIzvjestaja_Click(object sender, EventArgs e)
        {
            frmIndexIzvjestaj zaposleni = new frmIndexIzvjestaj();
            zaposleni.Show();
        }

        private void picEvidencijaZaposlenika_Click(object sender, EventArgs e)
        {
            frmOdabirZaposlenog zaposleni = new frmOdabirZaposlenog();
            zaposleni.Show();
        }

        private void pictObaveze_Click(object sender, EventArgs e)
        {
            frmIndexObaveza obaveza = new frmIndexObaveza();
            obaveza.Show();

        }
    }
}
