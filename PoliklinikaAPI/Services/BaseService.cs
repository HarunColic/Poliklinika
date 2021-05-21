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
    public class BaseService<T, TVM> : BaseInterface<T, TVM> where T : class
    {
        public readonly DBContext _db;
        public readonly IMapper _mapper;
        private readonly UserManager<User> _UsrManger;

        public BaseService(DBContext db, IMapper mapper, UserManager<User> UsrManger)
        {
            _mapper = mapper;
            _db = db;
            _UsrManger = UsrManger;
        }
        public void Delete(int id)
        {
            var t = _db.Set<T>().Find(id);
            _db.Set<T>().Remove(t);
            _db.SaveChanges();
        }

        public List<TVM> GetAll()
        {
            var Lista = _mapper.Map<List<TVM>>(_db.Set<T>().ToList());

            if(typeof(List<TVM>) == typeof(List<OsobljeVM>))
            {
                foreach(var i in Lista)
                {
                    var id = int.Parse(i.GetType().GetProperty("Id").GetValue(i, null).ToString());
                    var usr = _db.User.Find(id);

                    if (_db.Doktor.Find(id) != null)
                    {
                        i.GetType().GetProperty("Role").SetValue(i, "Doktor");
                    }
                    else
                    {
                        i.GetType().GetProperty("Role").SetValue(i, "Tehnicar");
                    }
                }
            }
            return Lista;
        }

        public TVM GetById(int id)
        {
            return _mapper.Map<TVM>(_db.Set<T>().Find(id));
        }

        public TVM Insert(TVM model)
        {
            var m = _mapper.Map<T>(model);

            _db.Set<T>().Add(m);
            _db.SaveChanges();

            return model;
        }

        public TVM Update(TVM model)
        {
            var m = _mapper.Map<T>(model);

            _db.Set<T>().Update(m);
            _db.SaveChanges();

            return model;
        }
    }
}
