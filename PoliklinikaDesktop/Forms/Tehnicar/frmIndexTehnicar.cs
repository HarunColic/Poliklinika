using PoliklinikaDesktop.Forms.Obaveza;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PoliklinikaDesktop.Forms.Tehnicar
{
    public partial class frmIndexTehnicar : Form
    {
        public frmIndexTehnicar()
        {
            InitializeComponent();
        }

        private void picObaveze_MouseClick(object sender, MouseEventArgs e)
        {
            var frmObaveze = new frmIndexOsobljeObaveza();
            frmObaveze.Show();
        }
    }
}
