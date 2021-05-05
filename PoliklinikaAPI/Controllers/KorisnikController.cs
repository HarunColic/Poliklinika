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
    public class KorisnikController : ControllerBase
    {
        protected KorisnikInterface _korisnikInterface;

        public KorisnikController(KorisnikInterface korisnikInterface)
        {
            _korisnikInterface = korisnikInterface;
        }


        [HttpGet]
        public IList<KorisnikVM> GetAll()
        {
            return _korisnikInterface.GetAll();
        }

        [HttpGet("{id}")]
        public KorisnikVM Get(int id)
        {
            return _korisnikInterface.Get(id);
        }

        [HttpPost]
        public KorisnikVM Insert(SignUpKorisnikVM korisnik)
        {
            return _korisnikInterface.Insert(korisnik);
        }

        [HttpPut("{id}")]
        public KorisnikVM Update(int id, KorisnikVM korisnik)
        {
            return _korisnikInterface.Update(id, korisnik);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _korisnikInterface.Delete(id);
        }
    }
}
