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
        public frmIzmjenaPodataka()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //if (CurrentUser.Role == "Doktor")
            //{
            //    var doc = await _doktor.GetById<DoktorVM>(CurrentUser.User.Id);
            //    doc.Email = txtEmail.Text;
            //    doc.
            //    await _doktor.Update<DoktorVM>();
            //}
        }
    }
}
