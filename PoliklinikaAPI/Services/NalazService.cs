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
    public class NalazService : NalazInterface
    {
        public readonly DBContext _db;
        public readonly IMapper _mapper;
        public NalazService(DBContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public Nalaz Get(int id)
        {
            return _db.Nalaz.Find(id);
        }

        public List<Nalaz> GetAll()
        {
            return _db.Nalaz.ToList();
        }
        public Nalaz Insert(NalazVM nalaz)
        {
            var entity = _mapper.Map<Nalaz>(nalaz);
            _db.Nalaz.Add(entity);
            _db.SaveChanges();
            return entity;
        }
        public Nalaz Update(int id, NalazVM nalaz)
        {
            var entity = _db.Nalaz.Find(id);
            _mapper.Map(nalaz, entity);
            _db.SaveChanges();
            return entity;
        }
        public void Delete(int id)
        {
            var nalaz = _db.Nalaz.Find(id);
            _db.Nalaz.Remove(nalaz);
            _db.SaveChanges();
        }


    }
}
