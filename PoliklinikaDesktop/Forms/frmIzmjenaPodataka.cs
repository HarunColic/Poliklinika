using Poliklinika.Model;
using PoliklinikaAPI.ViewModels;
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
        private readonly APIService _doktor = new APIService("Doktor");
        private readonly APIService _tehnicar = new APIService("Tehnicar");
        private readonly APIService _admin = new APIService("Admin");

        public frmIzmjenaPodataka()
        {
            InitializeComponent();
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (CurrentUser.Role == "Doktor")
            {
                var doc = await _doktor.GetById<DoktorVM>(CurrentUser.User.Id);

                if (txtEmail.Text != null && txtEmail.Text != "")
                    doc.Email = txtEmail.Text;
                    

                if(txtPassword.Text != null && txtPassword.Text != "")
                {

                }

                await _doktor.Update<DoktorVM>(doc);
            }
            else if(CurrentUser.Role == "Tehnicar")
            {

            }
            else
            {

            }
        }

        private async void UpdatePassword(string password, User user)
        {

        }
    }
}
