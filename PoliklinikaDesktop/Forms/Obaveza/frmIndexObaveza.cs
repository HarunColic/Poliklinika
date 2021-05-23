using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PoliklinikaDesktop.Forms.Obaveza
{
    public partial class frmIndexObaveza : Form
    {
        private readonly APIService _service = new APIService("Obaveza");
        public frmIndexObaveza()
        {
            InitializeComponent();
        }

        private void frmIndexObaveza_Load(object sender, EventArgs e)
        {
            
        }
    }
}
