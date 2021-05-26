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
    public class ObavezaController : ControllerBase
    {
        private BaseInterface<Obaveza, ObavezaVM> _baseInterface;
        public ObavezaController(BaseInterface<Obaveza, ObavezaVM> baseInterface)
        {
            _baseInterface = baseInterface;
        }

        [HttpGet]
        public List<ObavezaVM> GetAll()
        {
            return _baseInterface.GetAll();
        }

        [HttpGet("{id}")]
        public ObavezaVM Get(int id)
        {
            return _baseInterface.GetById(id);
        }

        [HttpPost]
        public ObavezaVM Insert(ObavezaVM model)
        {
            return _baseInterface.Insert(model);
        }

        [HttpPut]
        public ObavezaVM Update(ObavezaVM model)
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
