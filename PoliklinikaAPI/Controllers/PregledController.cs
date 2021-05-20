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
    public class PregledController : ControllerBase
    {
        private BaseInterface<Pregled, PregledVM> _baseInterface;

        public PregledController(BaseInterface<Pregled, PregledVM> baseInterface)
        {
            _baseInterface = baseInterface;
        }

        public List<PregledVM> GetAll()
        {
            return _baseInterface.GetAll();
        }

        [HttpGet("{id}")]
        public PregledVM Get(int id)
        {
            return _baseInterface.GetById(id);
        }

        [HttpPost]
        public PregledVM Insert(PregledVM model)
        {
            return _baseInterface.Insert(model);
        }

        [HttpPut("{id}")]
        public PregledVM Update(PregledVM model)
        {
            return _baseInterface.Update(model);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _baseInterface.Delete(id);
        }
    }
}
