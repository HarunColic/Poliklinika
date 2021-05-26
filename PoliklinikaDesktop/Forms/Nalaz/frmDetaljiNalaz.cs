using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PoliklinikaDesktop.Forms.Nalaz
{
    public partial class frmDetaljiNalaz : Form
    {
        private readonly APIService _service = new APIService("Nalaz");
        private int? _id = null;
        public frmDetaljiNalaz(int? nalazid = null)
        {
            InitializeComponent();
            _id = nalazid;
        }

        private void frmDetaljiNalaz_Load(object sender, EventArgs e)
        {

        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {

        }
    }
}
