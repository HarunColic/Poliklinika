using PoliklinikaAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoliklinikaDesktop.Forms.Doktor
{
   
    public partial class frmDetaljiDoktor : Form
    {
        private readonly APIService _service = new APIService("Doktor");
        private readonly APIService _odjel = new APIService("Odjel");
        private int? _id = null;

        public frmDetaljiDoktor(int? doktorid = null)
        {
            InitializeComponent();
            _id = doktorid;
        }

         CreateDoktorVM request = new CreateDoktorVM();
        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            request.Ime = txtIme.Text;
            request.Prezime = txtPrezime.Text;
            request.Specijalizacija = txtSpecijal.Text;
            request.SubSpecijalizacija = txtSubSecijal.Text;
            request.BrojRadneKnjizice = txtBrRadneKnjiz.Text;
            
           

            if (_id.HasValue)
            {
                
                await _service.Update<DoktorVM>(_id, request);
            }
            else
            {
                request.Email = txtEmail.Text;
                request.Password = txtPassword.Text;
                await _service.Insert<DoktorVM>(request);
            }
           
           
        }
        private async Task LoadOdjel()
        {
            var result = await _odjel.Get<List<Poliklinika.Model.Odjel>>();
            result.Insert(0, new Poliklinika.Model.Odjel());
            cmbOdjel.DisplayMember = "Naziv";
            cmbOdjel.ValueMember = "ID";
            cmbOdjel.DataSource = result;
        }

        private async void frmDetaljiDoktor_Load(object sender, EventArgs e)
        {
            await LoadOdjel();
            if (_id.HasValue)
            {
                var doc = await _service.GetById<DoktorVM>(_id);
                txtIme.Text = doc.Ime;
                txtPrezime.Text = doc.Prezime;
                txtSpecijal.Text = doc.Specijalizacija;
                txtSubSecijal.Text = doc.SubSpecijalizacija;
                txtBrRadneKnjiz.Text = doc.BrojRadneKnjizice;
                cmbSpol.SelectedText = doc.Spol;
                txtEmail.Hide();
                txtPassword.Hide();
                lblEmail.Hide();
                lblPassword.Hide();
            }
           
        }

        private void cmbOdjel_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbOdjel.SelectedValue;

            if (int.TryParse(idObj.ToString(), out int idodjel))
            {
                request.OdjelID = idodjel;
            }
        }

        private void cmbSpol_SelectedIndexChanged(object sender, EventArgs e)
        {
            request.Spol = cmbSpol.SelectedItem.ToString();
        }
    }
}
