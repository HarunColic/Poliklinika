using AutoMapper;
using PoliklinikaAPI.Data;
using PoliklinikaAPI.Interfaces;
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

        public BaseService(DBContext db, IMapper mapper)
        {
            _mapper = mapper;
            _db = db;
        }
        public void Delete(int id)
        {
            var t = _db.Set<T>().Find(id);
            _db.Set<T>().Remove(t);
            _db.SaveChanges();
        }

        public List<TVM> GetAll()
        {
            return _mapper.Map<List<TVM>>(_db.Set<T>().ToList());
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
