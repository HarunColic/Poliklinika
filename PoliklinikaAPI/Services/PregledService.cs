using AutoMapper;
using Microsoft.AspNetCore.Identity;
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
        public PregledService(DBContext db, IMapper mapper, UserManager<User> UsrManger) : base(db, mapper, UsrManger)
        {
        }

        public override List<PregledVM> GetAll(PregledVM search)
        {
            List<Pregled> list = new List<Pregled>();
            var preglediLista = _db.Pregled.ToList();
            var nalazLista = _db.Nalaz.ToList();
            
            if (search == null)
            {
                return _mapper.Map<List<PregledVM>>(preglediLista);
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
                return _mapper.Map<List<PregledVM>>(list);
            }   
        }
    }
}
