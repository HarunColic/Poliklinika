using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Poliklinika.Model;
using PoliklinikaAPI.Data;
using PoliklinikaAPI.Interfaces;
using PoliklinikaAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PoliklinikaAPI.Services
{
    public class KorisnikService : KorisnikInterface
    {
        private DBContext _db;
        private IMapper _mapper;
        UserManager<User> _userManager;
        RoleManager<Role> _roleManager;

        public KorisnikService(DBContext db, IMapper mapper, UserManager<User> userManager, RoleManager<Role> roleManager)
        {
            _db = db;
            _mapper = mapper;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public void Delete(int id)
        {
            var korisnik = _db.Korisnik.Find(id);

            _db.Korisnik.Remove(korisnik);
            _db.SaveChanges();

        }

        public KorisnikVM Get(int id)
        {
            return _mapper.Map<KorisnikVM>(_db.Korisnik.Find(id));
        }

        public IList<KorisnikVM> GetAll()
        {
            return _mapper.Map<IList<KorisnikVM>>(_db.Korisnik.ToList());
        }

        public KorisnikVM Insert(SignUpKorisnikVM korisnik)
        {
            var signupKorisnik = _mapper.Map<SignUpKorisnikVM, Korisnik>(korisnik);
            signupKorisnik.UserName = korisnik.Email;

            var userCreateResult = _userManager.CreateAsync(signupKorisnik, korisnik.Password);

            var role = _roleManager.FindByNameAsync("Korisnik").Result.Name;

            if (userCreateResult.Result.Succeeded )
            {
                var k = _db.Korisnik.Find(signupKorisnik.Id);
                _userManager.AddToRoleAsync(k, role);
                return _mapper.Map<SignUpKorisnikVM, KorisnikVM>(korisnik);
            }

            var errors = new List<Exception>();

            foreach(var e in userCreateResult.Result.Errors)
            {
                errors.Add(new Exception(e.Description));
            }

            throw new AggregateException(errors);
        }

        public KorisnikVM Update(int id, KorisnikVM korisnik)
        {
            var entity = _db.Korisnik.Find(id);
            var map = _mapper.Map<KorisnikVM>(entity);
            _db.SaveChanges();
            return map;
        }
    }
}
