using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Poliklinika.Model;
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

        public AdminController(UserBaseInterface<Admin, Admin, SignupAdminVM> userInterface)
        {
            _userInterface = userInterface;
        }

        [HttpPost]
        public Admin Insert(SignupAdminVM korisnik)
        {
            return _userInterface.Insert(korisnik);
        }

        [HttpGet("{id}")]
        public Admin Get(int id)
        {
            return _userInterface.Get(id);
        }
    }
}
