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
    public class NalazService : BaseService<Nalaz, NalazVM>
    {
        public NalazService(DBContext db, IMapper mapper, UserManager<User> UsrManger) : base(db, mapper, UsrManger)
        {
        }

        public override List<NalazVM> GetAll(NalazVM search)
        {
            List<Nalaz> list = new List<Nalaz>();
            var nalazLista = _db.Nalaz.ToList();

            if (search == null)
            {
                return _mapper.Map<List<NalazVM>>(nalazLista);
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
