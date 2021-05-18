using PoliklinikaAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PoliklinikaDesktop.Forms.Tehnicar
{
    public partial class frmDetaljiTehnicar : Form
    {
        private readonly APIService _service = new APIService("Tehnicar");
        private int? _id = null;
        public frmDetaljiTehnicar(int? tehnicarid = null)
        {
            InitializeComponent();
            _id = tehnicarid;
        }
        CreateTehnicarVM request = new CreateTehnicarVM();
        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            request.Ime = txtIme.Text;
            request.Prezime = txtPrezime.Text;
            request.StrucnaSprema = txtstrucna.Text;
            

            if (_id.HasValue)
            {
                await _service.Update<TehnicarVM>(_id, request);
            }
            else
            {
                request.Password = txtPassword.Text;
                request.Email = txtEmail.Text;
                await _service.Insert<TehnicarVM>( request);
            }
        }

        private void cmbSpol_SelectedIndexChanged(object sender, EventArgs e)
        {  
            request.Spol = (string)cmbSpol.SelectedValue;
        }

        private void frmDetaljiTehnicar_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                txtEmail.Hide();
                txtPassword.Hide();
                lblEmail.Hide();
                lblPassword.Hide();
            }
        }
    }
}
