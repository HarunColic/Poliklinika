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
        UserManager<Korisnik> _userManager;
        RoleManager<Role> _roleManager;

        public KorisnikService(DBContext db, IMapper mapper, UserManager<Korisnik> userManager, RoleManager<Role> roleManager)
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

            var userCreateResult = _userManager.CreateAsync(signupKorisnik, korisnik.Password);

            var role = new Role { Name = "Korisnik" };
            var userRoleResult = _roleManager.CreateAsync(role);

            if (userCreateResult.Result.Succeeded && userRoleResult.Result.Succeeded)
            {
                var k = _db.Korisnik.Find(signupKorisnik.Id);
                _userManager.AddToRoleAsync(k, role.Name);
                return _mapper.Map<KorisnikVM>(korisnik);
            }

            return null;
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
