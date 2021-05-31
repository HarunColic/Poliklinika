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
    public class RasporedController : ControllerBase
    {
        private BaseInterface<Raspored, RasporedVM> _baseInterface;

        public RasporedController(BaseInterface<Raspored, RasporedVM> baseInterface)
        {
            _baseInterface = baseInterface;
        }

        [HttpGet]
        public List<RasporedVM> Index()
        {
            return _baseInterface.GetAll();
        }

        [HttpGet("{id}")]
        public RasporedVM Get(int id)
        {
            return _baseInterface.GetById(id);
        }

        [HttpPost]
        public RasporedVM Insert(RasporedVM model)
        {
            return _baseInterface.Insert(model);
        }

        [HttpPut]
        public RasporedVM Update(RasporedVM model)
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
