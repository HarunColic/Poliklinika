using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Poliklinika.Model;
using PoliklinikaAPI.Data;
using PoliklinikaAPI.Interfaces;
using PoliklinikaAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoliklinikaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        protected UserBaseInterface<Admin, Admin, SignupAdminVM> _userInterface;
        private DBContext _db;
        public AdminController(UserBaseInterface<Admin, Admin, SignupAdminVM> userInterface, DBContext db)
        {
            _userInterface = userInterface;
            _db = db;
        }

        [HttpGet]
        public Admin Index()
        {
            return _db.Admin.FirstOrDefault();
        }

        [HttpPost]
        public async Task<Admin> Insert(SignupAdminVM korisnik)
        {
            return await _userInterface.Insert(korisnik);
        }

        [HttpGet("{id}")]
        public Admin Get(int id)
        {
            return _userInterface.Get(id);
        }

        [HttpPost("update-password")]
        public void UpdatePassword(UpdatePasswordVM update)
        {
            _userInterface.UpdatePassword(update);
        }
    }
}
