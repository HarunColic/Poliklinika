using AutoMapper;
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
    public class OdjelService : OdjelInterface
    {
        public readonly DBContext _db;
        public readonly IMapper _mapper;

        public OdjelService(DBContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public Odjel Insert(OdjelVM odjel)
        {
            var entity = _mapper.Map<Odjel>(odjel);
            _db.Odjel.Add(entity);
            _db.SaveChanges();
            return entity;
        }

        public void Delete(int id)
        {
            var o = _db.Odjel.Find(id);
            _db.Odjel.Remove(o);
            _db.SaveChanges();
        }

        public Odjel Get(int id)
        {
            return _db.Odjel.Find(id);
        }

        public List<Odjel> GetAll()
        {
            return _db.Odjel.ToList();
        }

        public Odjel Update(int id, OdjelVM odjel)
        {
            var entity = _db.Odjel.Find(id);
            _mapper.Map(odjel, entity);
            _db.SaveChanges();
            return entity;
        }
    }
}
