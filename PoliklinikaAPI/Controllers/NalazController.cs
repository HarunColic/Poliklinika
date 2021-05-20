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
        private readonly NalazInterface _nalazInterface;
        public NalazController(NalazInterface nalazInterface)
        {
            _nalazInterface = nalazInterface;
        }

        [HttpGet]
        public List<Nalaz> GetAll()
        {
            return _nalazInterface.GetAll();
        }

        [HttpGet("{id}")]
        public Nalaz Get(int id)
        {
            return _nalazInterface.Get(id);
        }

        [HttpPost]
        public Nalaz Insert(NalazVM nalaz)
        {
            return _nalazInterface.Insert(nalaz);
        }

        [HttpPut("{id}")]
        public Nalaz Update(int id, NalazVM nalaz)
        {
            return _nalazInterface.Update(id, nalaz);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _nalazInterface.Delete(id);
        }
    }
}
