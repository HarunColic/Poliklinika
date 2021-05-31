using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PoliklinikaDesktop.Forms.Raspored
{
    public partial class frmIndexRaspored : Form
    {
        private readonly APIService _service = new APIService("Raspored");
        public frmIndexRaspored()
        {
            InitializeComponent();
        }

        private async void frmIndexRaspored_Load(object sender, EventArgs e)
        {
            //var result = await _service.Get
        }
    }
}
