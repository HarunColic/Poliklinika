using PoliklinikaAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PoliklinikaDesktop.Forms.Nalaz
{
    public partial class frmIndexNalaz : Form
    {
        private readonly  APIService _service = new APIService("Nalaz");
        private readonly APIService _pregled = new APIService("Pregled");
        public frmIndexNalaz()
        {
            InitializeComponent();
        }

        private async void frmIndexNalaz_Load(object sender, EventArgs e)
        {
            var id=CurrentUser.User.Id;

            var result = await _pregled.Get<List<PregledVM>>(new PregledVM()
            {
                DoktorID = id
            });

            dgvPregled.DataSource = result;

            var result2 = await _service.Get<List<NalazVM>>(new PregledVM()
            {
                DoktorID = id
            });

            dgvNalaz.DataSource = result2;

        }
    }
}
