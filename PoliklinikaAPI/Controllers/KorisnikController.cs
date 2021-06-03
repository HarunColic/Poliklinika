using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Poliklinika.Model;
using PoliklinikaAPI.Data;
using PoliklinikaAPI.Interfaces;
using PoliklinikaAPI.ViewModels;

namespace PoliklinikaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KorisnikController : ControllerBase
    {
        protected UserBaseInterface<Korisnik, KorisnikVM, SignUpKorisnikVM> _userInterface;
        private readonly DBContext _db;

        public KorisnikController(UserBaseInterface<Korisnik, KorisnikVM, SignUpKorisnikVM> userInterface, DBContext db)
        {
            _userInterface = userInterface;
            _db = db;
        }


        [HttpGet]
        public IList<KorisnikVM> GetAll()
        {
            return _userInterface.GetAll();
        }

        [HttpGet("{id}")]
        public Korisnik Get(int id)
        {
            return _db.Korisnik.Find(id);
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

        [HttpPost("update-password")]
        public void UpdatePassword(UpdatePasswordVM update)
        {
            _userInterface.UpdatePassword(update);
        }
    }
}
