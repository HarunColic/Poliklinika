using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PoliklinikaDesktop.Forms
{
    public partial class frmIzmjenaPodataka : Form
    {
        private int? _id = null;
        public frmIzmjenaPodataka(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
