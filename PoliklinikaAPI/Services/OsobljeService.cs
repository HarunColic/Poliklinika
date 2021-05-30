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
    public class OsobljeService : BaseService<Osoblje, OsobljeVM>
    {
        public OsobljeService(DBContext db, IMapper mapper, UserManager<User> UsrManger) : base(db, mapper, UsrManger)
        {
        }

        //public override List<OsobljeVM> GetAll()
        //{
        //   var s=_db.Osoblje.Where(x=>x.)
        //}
    }
}
