using AutoMapper;
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
        public IzvjestajService(DBContext db, IMapper mapper) : base(db, mapper)
        {

        }
        //public override List<IzvjestajVM> GetAll()
        //{
        //    var query = _db.Set<Izvjestaj>().AsQueryable();

        //    if (search?.VrstaId.HasValue == true)
        //    {
        //        query = query.Where(x => x.VrstaId == search.VrstaId);
        //    }

        //    query = query.OrderBy(x => x.Naziv);

        //    var list = query.ToList();
        //    return base.GetAll();
        //}
    }
}
