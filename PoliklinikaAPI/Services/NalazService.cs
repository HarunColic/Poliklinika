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
    public class NalazService : BaseService<Nalaz, NalazVM>
    {
        public readonly DBContext _contex;
        public readonly IMapper _Mapper;
        public NalazService(DBContext db, IMapper mapper) : base(db, mapper)
        {
            _contex = db;
            _Mapper = mapper;
        }

        public override List<NalazVM> GetAll(NalazVM search)
        {
            List<Nalaz> list = new List<Nalaz>();
            var nalazLista = _contex.Nalaz.ToList();

            if (search == null)
            {
                return _Mapper.Map<List<NalazVM>>(nalazLista);
            }
            //else
            //{
            //    foreach (var i in nalazLista)
            //    {
            //        if(i.Pregled.DoktorID==search.PregledID)
            //    }
            //}


            return base.GetAll(search);
        }
    }
}
