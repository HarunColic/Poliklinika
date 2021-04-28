using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Poliklinika.Model;
using PoliklinikaAPI.Interfaces;
using PoliklinikaAPI.ViewModels;

namespace PoliklinikaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OdjelController : ControllerBase
    {
        protected OdjelInterface _odjelInterface;

        public OdjelController(OdjelInterface odjelInterface)
        {
            _odjelInterface = odjelInterface;
        }

        [HttpGet]
        public List<Odjel> GetAll()
        {
            return _odjelInterface.GetAll();
        }

        [HttpGet("{id}")]
        public Odjel Get(int id)
        {
            return _odjelInterface.Get(id);
        }

        [HttpPost]
        public Odjel Insert(OdjelVM odjel)
        {
            return _odjelInterface.Insert(odjel);
        }

        [HttpPut("{id}")]
        public Odjel Update(int id, OdjelVM odjel)
        {
            return _odjelInterface.Update(id, odjel);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
             _odjelInterface.Delete(id);
        }
    }
}
