﻿using Microsoft.AspNetCore.Http;
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
        protected UserBaseInterface<Admin, SignupAdminVM, SignupAdminVM> _userInterface;

        public AdminController(UserBaseInterface<Admin, SignupAdminVM, SignupAdminVM> userInterface)
        {
            _userInterface = userInterface;
        }

        [HttpPost]
        public SignupAdminVM Insert(SignupAdminVM korisnik)
        {
            return _userInterface.Insert(korisnik);
        }

        [HttpGet("{id}")]
        public SignupAdminVM Get(int id)
        {
            return _userInterface.Get(id);
        }
    }
}