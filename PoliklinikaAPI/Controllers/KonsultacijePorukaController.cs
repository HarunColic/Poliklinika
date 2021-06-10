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
    public class KonsultacijePorukaController : ControllerBase
    {
        private BaseInterface<KonsultacijePoruka, KonsultacijePorukaVM> _baseInterface;

        public KonsultacijePorukaController(BaseInterface<KonsultacijePoruka, KonsultacijePorukaVM> baseInterface)
        {
            _baseInterface = baseInterface;
        }

        [HttpGet]
        public List<KonsultacijePorukaVM> Index()
        {
            return _baseInterface.GetAll();
        }

        [HttpPost]
        public KonsultacijePorukaVM Insert(KonsultacijePorukaVM model)
        {
            return _baseInterface.Insert(model);
        }
    }
}
