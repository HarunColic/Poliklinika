using AutoMapper;
using Microsoft.AspNetCore.Identity;
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

        public IzvjestajService(DBContext db, IMapper mapper, UserManager<User> UsrManger) : base(db, mapper, UsrManger)
        {
        }

        public override List<IzvjestajVM> GetAll(IzvjestajVM search)
        {
            var query = _db.Set<Izvjestaj>().AsQueryable();

            if (search?.OdjelID!=null)
            {
                query = query.Include(x=>x.Pregled.Doktor)
                    .Where(x=>x.Pregled.Doktor.OdjelID==search.OdjelID);
            }

            query = query.Include(x=>x.Pregled.Doktor).OrderBy(x=>x.Pregled.Doktor.Prezime);

            var list = query.ToList();

            return _mapper.Map<List<IzvjestajVM>>(list);
        }

    }
}
