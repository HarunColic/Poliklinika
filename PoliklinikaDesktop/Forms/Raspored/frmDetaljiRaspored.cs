using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PoliklinikaDesktop.Forms.Raspored
{
    public partial class frmDetaljiRaspored : Form
    {
        private readonly int? _id;
        public frmDetaljiRaspored(int? rasporedid)
        {
            InitializeComponent();
            _id = rasporedid;
        }

        private void frmDetaljiRaspored_Load(object sender, EventArgs e)
        {
            dtpKraj.Format = DateTimePickerFormat.Custom;
            dtpKraj.CustomFormat = "HH:mm";
        }
    }
}
