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
    public partial class frmLogin : Form
    {
        private readonly APIService _service = new APIService("Authentication");
        private readonly APIService _userService = new APIService("Osoblje");

        public frmLogin()
        {
            InitializeComponent();
        }

        AuthenticateRequest request = new AuthenticateRequest();

        private async void btnPrijava_Click(object sender, EventArgs e)
        {
            request.Email = textEmail.Text;
            request.Password = textPassword.Text;

            var result = await _service.Insert<AuthenticateResponse>(request);

            var user = new User();

            if (result.Role == "Doktor")
                user = await _userService.GetById<Poliklinika.Model.Doktor>(result.Id);
            else if (result.Role == "Tehnicar")
                user = await _userService.GetById<Poliklinika.Model.Tehnicar>(result.Id);
            else if (result.Role == "Admin")
                user = await _userService.GetById<Poliklinika.Model.Admin>(result.Id);
            else
                throw new Exception("Korisnika nije moguce ulogovati");

            CurrentUser.Role = result.Role;
            CurrentUser.JWT = result.Token;
            CurrentUser.User = user;

            var test = "TEST";
        }

    }
}
