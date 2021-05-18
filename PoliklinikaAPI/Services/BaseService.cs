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

        public TVM insert(TVM model)
        {
            throw new NotImplementedException();
        }

        public TVM update(TVM model)
        {
            throw new NotImplementedException();
        }
    }
}
