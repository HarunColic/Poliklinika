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
    public class UserBaseService<T, TVM, TCreateVM> : UserBaseInterface<T, TVM, TCreateVM> where T: class
    {
        private DBContext _db;
        private IMapper _mapper;
        private UserManager<User> _userManager;
        private RoleManager<Role> _roleManager;

        public UserBaseService(DBContext db, IMapper mapper, UserManager<User> userManager, RoleManager<Role> roleManager)
        {
            _db = db;
            _mapper = mapper;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public void Delete(int id)
        {
            var user = _db.Set<T>().Find(id);

            _db.Set<T>().Remove(user);
            _db.SaveChanges();

        }

        public TVM Get(int id)
        {
            return _mapper.Map<TVM>(_db.Set<T>().Find(id));
        }

        public IList<TVM> GetAll()
        {
            return _mapper.Map<IList<TVM>>(_db.Set<T>().ToList());
        }

        public TVM Insert(TCreateVM user)
        {
            User signupUser;
            string roleName = "";

            if (typeof(T) == typeof(Korisnik))
            {
                signupUser = _mapper.Map<TCreateVM, Korisnik>(user);
                roleName = nameof(Korisnik);
            }
            else if (typeof(T) == typeof(Doktor))
            {
                signupUser = _mapper.Map<TCreateVM, Doktor>(user);
                roleName = nameof(Doktor);
            }
            else
            {
                signupUser = _mapper.Map<TCreateVM, Tehnicar>(user);
                roleName = nameof(Tehnicar);
            }

            var mail = user.GetType().GetProperty("Email").GetValue(user, null);
            signupUser.GetType().GetProperty("UserName").SetValue(signupUser, mail);
            signupUser.Spol = user.GetType().GetProperty("Spol").GetValue(user, null).ToString();

            var userCreateResult = _userManager.CreateAsync(signupUser, user.GetType().GetProperty("Password").GetValue(user, null).ToString());
            userCreateResult.Wait();

            string role = null;

            try
            {
                role = _roleManager.FindByNameAsync(roleName).Result.Name;
            }
            catch (Exception)
            {
                if (role == null || role == "")
                {
                    var createRole = new Role { Name = roleName };
                    var result = _roleManager.CreateAsync(createRole);
                    result.Wait();
                    role = _roleManager.FindByNameAsync(roleName).Result.Name;
                }
            }

            if (userCreateResult.Result.Succeeded)
            {
                User k;

                if (typeof(T) == typeof(Korisnik))
                    k = _db.Korisnik.Find(signupUser.GetType().GetProperty("Id").GetValue(signupUser, null));
                else if (typeof(T) == typeof(Doktor))
                    k = _db.Doktor.Find(signupUser.GetType().GetProperty("Id").GetValue(signupUser, null));
                else
                    k = _db.Tehnicar.Find(signupUser.GetType().GetProperty("Id").GetValue(signupUser, null));

                _userManager.AddToRoleAsync(k, role);
                return _mapper.Map<TCreateVM, TVM>(user);
            }

            var errors = new List<Exception>();

            foreach (var e in userCreateResult.Result.Errors)
            {
                errors.Add(new Exception(e.Description));
            }

            throw new AggregateException(errors);
        }

        public TVM Update(int id, TVM user)
        {
            var entity = _db.Set<T>().Find(id);
            var map = _mapper.Map<TVM>(entity);
            _db.SaveChanges();
            return map;
        }
    }
}
