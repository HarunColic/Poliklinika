﻿using PoliklinikaDesktop.Forms.Nalaz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PoliklinikaDesktop.Forms.Doktor
{
    public partial class frmIndexDoktor : Form
    {
        public frmIndexDoktor()
        {
            InitializeComponent();
        }

        private void picNalaz_Click(object sender, EventArgs e)
        {
            frmIndexNalaz nalaz = new frmIndexNalaz();
            nalaz.Show();
        }
    }
}
