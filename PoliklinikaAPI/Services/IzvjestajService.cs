using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Poliklinika.Model;
using PoliklinikaAPI.Data;
using PoliklinikaAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoliklinikaAPI.Services
{
    public class IzvjestajService : BaseService<Izvjestaj, IzvjestajVM>
    {
        public readonly DBContext _contex;
        public readonly IMapper _Mapper;
        public IzvjestajService(DBContext db, IMapper mapper) : base(db, mapper)
        {
            _contex = db;
            _Mapper = mapper;
        }

        public override List<IzvjestajVM> GetAll(IzvjestajVM search)
        {
            var query = _contex.Set<Izvjestaj>().AsQueryable();

            if (search?.OdjelID!=null)
            {
                query = query.Include(x=>x.Pregled.Doktor)
                    .Where(x=>x.Pregled.Doktor.OdjelID==search.OdjelID);
            }

            query = query.Include(x=>x.Pregled.Doktor).OrderBy(x=>x.Pregled.Doktor.Prezime);

            var list = query.ToList();

            return _Mapper.Map<List<IzvjestajVM>>(list);
        }

    }
}
