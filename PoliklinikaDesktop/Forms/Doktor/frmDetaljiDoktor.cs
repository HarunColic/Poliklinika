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

            if (this.ValidateChildren())
            {
                request.Ime = txtIme.Text;
                request.Prezime = txtPrezime.Text;
                request.Specijalizacija = txtSpecijal.Text;
                request.SubSpecijalizacija = txtSubSecijal.Text;
                request.BrojRadneKnjizice = txtBrRadneKnjiz.Text;

                if (_id.HasValue)
                {
                    var doktor = await _service.GetById<DoktorVM>(_id);

                    doktor.Ime = txtIme.Text;
                    doktor.Prezime = txtPrezime.Text;
                    doktor.Specijalizacija = txtSpecijal.Text;
                    doktor.SubSpecijalizacija = txtSubSecijal.Text;
                    doktor.BrojRadneKnjizice = txtBrRadneKnjiz.Text;

                    await _service.Update<DoktorVM>(doktor);
                }
                else
                {
                    request.Email = txtEmail.Text;
                    request.Password = txtPassword.Text;
                    await _service.Insert<DoktorVM>(request);
                }
                MessageBox.Show("Operacija uspješna");
            }

           
           
           
        }
        private async Task LoadOdjel()
        {
            var result = await _odjel.Get<List<Poliklinika.Model.Odjel>>(null);
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
                cmbOdjel.SelectedValue = doc.OdjelID;
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
            request.Spol = cmbSpol.SelectedText;
        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            var _validator = new Validatori(sender, e, errorProvider);
            _validator.ValidacijaPraznogStringa(txtIme);
        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            var _validator = new Validatori(sender, e, errorProvider);
            _validator.ValidacijaPraznogStringa(txtPrezime);
        }

        private void txtSpecijal_Validating(object sender, CancelEventArgs e)
        {
            var _validator = new Validatori(sender, e, errorProvider);
            _validator.ValidacijaPraznogStringa(txtSpecijal);
        }

        private void txtSubSecijal_Validating(object sender, CancelEventArgs e)
        {
            var _validator = new Validatori(sender, e, errorProvider);
            _validator.ValidacijaPraznogStringa(txtSubSecijal);
        }

        private void txtBrRadneKnjiz_Validating(object sender, CancelEventArgs e)
        {
            var _validator = new Validatori(sender, e, errorProvider);
            _validator.ValidacijaPraznogStringa(txtBrRadneKnjiz);
        }

        private void cmbOdjel_Validating(object sender, CancelEventArgs e)
        {
            var _validator = new Validatori(sender, e, errorProvider);
            _validator.ValidacijaPraznogStringacmb(cmbOdjel);
           
        }

        private void cmbSpol_Validating(object sender, CancelEventArgs e)
        {
            var _validator = new Validatori(sender, e, errorProvider);
            _validator.ValidacijaPraznogStringacmb(cmbSpol);
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (_id == null)
            {

                var _validator = new Validatori(sender, e, errorProvider);
                _validator.ValidacijaPraznogStringa(txtEmail);
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (_id == null)
            {

                var _validator = new Validatori(sender, e, errorProvider);
                _validator.ValidacijaPraznogStringa(txtPassword);
            }
        }
    }
}
