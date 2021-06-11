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
    public class KonsultacijeController : ControllerBase
    {
        private BaseInterface<Konsultacije, KonsultacijeVM> _baseInterface;

        public KonsultacijeController(BaseInterface<Konsultacije, KonsultacijeVM> baseInterface)
        {
            _baseInterface = baseInterface;
        }

        [HttpGet]
        public List<KonsultacijeVM> Index()
        {
            return _baseInterface.GetAll();
        }

        [HttpGet("{id}")]
        public KonsultacijeVM Get(int id)
        {
            return _baseInterface.GetById(id);
        }

        [HttpPost]
        public KonsultacijeVM Insert(KonsultacijeVM model)
        {
            return _baseInterface.Insert(model);
        }
    }
}
