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
    public class NalazController : Controller
    {
        private readonly BaseInterface<Nalaz, NalazVM> _nalazInterface;
        public NalazController(BaseInterface<Nalaz, NalazVM> nalazInterface)
        {
            _nalazInterface = nalazInterface;
        }

        [HttpGet]
        public List<NalazVM> GetAll()
        {
            return _nalazInterface.GetAll();
        }

        [HttpGet("{id}")]
        public NalazVM Get(int id)
        {
            return _nalazInterface.GetById(id);
        }

        [HttpPost]
        public NalazVM Insert(NalazVM nalaz)
        {
            return _nalazInterface.Insert(nalaz);
        }

        [HttpPut("{id}")]
        public NalazVM Update(NalazVM nalaz)
        {
            return _nalazInterface.Update(nalaz);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _nalazInterface.Delete(id);
        }
    }
}
