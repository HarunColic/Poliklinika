﻿using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
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

        public async Task<TVM> Insert(TCreateVM user)
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
            else if (typeof(T) == typeof(Tehnicar))
            {
                signupUser = _mapper.Map<TCreateVM, Tehnicar>(user);
                roleName = nameof(Tehnicar);
            }
            else
            {
                signupUser = _mapper.Map<TCreateVM, Admin>(user);
                roleName = nameof(Admin);
            }

            var mail = user.GetType().GetProperty("Email").GetValue(user, null);
            signupUser.GetType().GetProperty("UserName").SetValue(signupUser, mail);
            if(typeof(TCreateVM) != typeof(SignupAdminVM))
                signupUser.Spol = user.GetType().GetProperty("Spol").GetValue(user, null).ToString();

            var userCreateResult = await _userManager.CreateAsync(signupUser, user.GetType().GetProperty("Password").GetValue(user, null).ToString());

            string role = null;

            try
            {
                var rlResult = await _roleManager.FindByNameAsync(roleName);
                role = rlResult.Name;
            }
            catch (Exception)
            {
                if (role == null || role == "")
                {
                    var createRole = new Role { Name = roleName };
                    var result = await _roleManager.CreateAsync(createRole);
                    var roleResult = await _roleManager.FindByNameAsync(roleName);
                    role = roleResult.Name;
                }
            }

            if (userCreateResult.Succeeded)
            {
                User k;

                if (typeof(T) == typeof(Korisnik))
                    k = await _db.Korisnik.FindAsync(signupUser.GetType().GetProperty("Id").GetValue(signupUser, null));
                else if (typeof(T) == typeof(Doktor))
                    k = await _db.Doktor.FindAsync(signupUser.GetType().GetProperty("Id").GetValue(signupUser, null));
                else if (typeof(T) == typeof(Tehnicar))
                    k = await _db.Tehnicar.FindAsync(signupUser.GetType().GetProperty("Id").GetValue(signupUser, null));
                else
                    k = _db.Admin.Find(signupUser.GetType().GetProperty("Id").GetValue(signupUser, null));

                foreach (var i in this._db.ChangeTracker.Entries())
                {
                    if (i.Entity != null)
                    {
                        _db.Entry(i).State = EntityState.Detached;
                    }
                }

                await _userManager.AddToRoleAsync(k, role);
                return _mapper.Map<TCreateVM, TVM>(user);
            }

            var errors = new List<Exception>();

            foreach (var e in userCreateResult.Errors)
            {
                errors.Add(new Exception(e.Description));
            }

            throw new AggregateException(errors);
        }

        public TVM Update(TVM user)
        {
            var entity = _db.Set<T>().Find(int.Parse(user.GetType().GetProperty("Id").GetValue(user, null).ToString()));
            var map = _mapper.Map(user, entity);
            _db.SaveChanges();
            return _mapper.Map<TVM>(map);
        }
    }
}
