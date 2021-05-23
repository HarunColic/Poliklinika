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
    public class UplataController : ControllerBase
    {
        private BaseInterface<Uplata, UplataVM> _baseInterface;

        public UplataController(BaseInterface<Uplata, UplataVM> baseInterface)
        {
            _baseInterface = baseInterface;
        }

        [HttpGet]
        public List<UplataVM> GetAll()
        {
            return _baseInterface.GetAll();
        }

        [HttpGet("{id}")]
        public UplataVM Get(int id)
        {
            return _baseInterface.GetById(id);
        }

        [HttpPost]
        public UplataVM Insert(UplataVM model)
        {
            return _baseInterface.Insert(model);
        }

        [HttpPut("{id}")]
        public UplataVM Update(UplataVM model)
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
