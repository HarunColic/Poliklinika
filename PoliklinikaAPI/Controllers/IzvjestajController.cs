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
    public class IzvjestajController : ControllerBase
    {
        private BaseInterface<Izvjestaj, IzvjestajVM> _baseInterface;
        public IzvjestajController(BaseInterface<Izvjestaj, IzvjestajVM> baseInterface)
        {
            _baseInterface = baseInterface;
        }
        
        [HttpGet]
        public List<IzvjestajVM> GetAll()
        {
            return _baseInterface.GetAll(null);
        }

        [HttpGet("{id}")]
        public IzvjestajVM Get(int id)
        {
            return _baseInterface.GetById(id);
        }

        [HttpPost]
        public IzvjestajVM Insert(IzvjestajVM model)
        {
            return _baseInterface.Insert(model);
        }

        [HttpPut("{id}")]
        public IzvjestajVM Update(IzvjestajVM model)
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
