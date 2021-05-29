using PoliklinikaAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PoliklinikaDesktop.Forms.Obaveza
{
    public partial class frmDetaljiOsobljeObaveza : Form
    {
        private readonly APIService _service = new APIService("Obaveza");
        private readonly APIService _odjel = new APIService("Odjel");

        private int _id;

        public frmDetaljiOsobljeObaveza(int ObavezaID)
        {
            InitializeComponent();
            _id = ObavezaID;
        }

        private async void frmDetaljiOsobljeObaveza_Load(object sender, EventArgs e)
        {
            var Obaveza = await _service.GetById<ObavezaVM>(_id);
            var Odjel = await _odjel.GetById<OdjelVM>(Obaveza.OdjelID);

            lblOpis.Text = Obaveza.Opis;
            lblDatum.Text = Obaveza.Datum.ToString();
            lblOdjel.Text = Odjel.Naziv;

            if (!Obaveza.Aktivna)
                btnChat.Visible = false;

        }
    }
}
