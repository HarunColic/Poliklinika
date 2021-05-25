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
    public class PregledService : BaseService<Pregled, PregledVM>
    {
        public readonly DBContext _contex;
        public readonly IMapper _Mapper;
        public PregledService(DBContext db, IMapper mapper) : base(db, mapper)
        {
            _contex = db;
            _Mapper = mapper;
        }

        public override List<PregledVM> GetAll(PregledVM search)
        {
            List<Pregled> list = new List<Pregled>();
            var preglediLista = _contex.Pregled.ToList();
            var nalazLista = _contex.Nalaz.ToList();
            
            if (search == null)
            {
                return _Mapper.Map<List<PregledVM>>(preglediLista);
            }
            else
            {

                foreach (var i in preglediLista)
                {
                    if (i.DoktorID == search.DoktorID)
                    {
                        list.Add(i);
                    }
                }

                foreach (var i in nalazLista)
                {
                    foreach (var j in list)
                    {
                        if (i.PregledID == j.ID)
                        {
                            list.Remove(j);
                        }
                    }
                }
                return _Mapper.Map<List<PregledVM>>(list);
            }   
        }
    }
}
