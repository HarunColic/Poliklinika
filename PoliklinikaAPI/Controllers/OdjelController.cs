using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
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
        protected BaseInterface<Odjel, OdjelVM> _odjelInterface;

        public OdjelController(BaseInterface<Odjel, OdjelVM> odjelInterface)
        {
            _odjelInterface = odjelInterface;
        }

        [HttpGet]
        public List<OdjelVM> GetAll()
        {
            return _odjelInterface.GetAll(null);
        }

        [HttpGet("{id}")]
        public OdjelVM Get(int id)
        {
            return _odjelInterface.GetById(id);
        }

        [HttpPost]
        public OdjelVM Insert(OdjelVM odjel)
        {
            return _odjelInterface.Insert(odjel);
        }

        [HttpPut("{id}")]
        public OdjelVM Update(OdjelVM odjel)
        {
            return _odjelInterface.Update(odjel);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
             _odjelInterface.Delete(id);
        }
    }
}
