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
        protected UserBaseInterface<Korisnik, KorisnikVM, SignUpKorisnikVM> _userInterface;

        public KorisnikController(UserBaseInterface<Korisnik, KorisnikVM, SignUpKorisnikVM> userInterface)
        {
            _userInterface = userInterface;
        }


        [HttpGet]
        public IList<KorisnikVM> GetAll()
        {
            return _userInterface.GetAll();
        }

        [HttpGet("{id}")]
        public KorisnikVM Get(int id)
        {
            return _userInterface.Get(id);
        }

        [HttpPost]
        public async Task<KorisnikVM> Insert(SignUpKorisnikVM korisnik)
        {
            return await _userInterface.Insert(korisnik);
        }

        [HttpPut]
        public KorisnikVM Update(KorisnikVM korisnik)
        {
            return _userInterface.Update(korisnik);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _userInterface.Delete(id);
        }
    }
}
