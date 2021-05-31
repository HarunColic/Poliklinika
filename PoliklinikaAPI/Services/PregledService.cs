using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Poliklinika.Model;
using PoliklinikaAPI.Data;
using PoliklinikaAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace PoliklinikaAPI.Services
{
    public class PregledService : BaseService<Pregled, PregledVM>
    {
        HttpContextAccessor _context = new HttpContextAccessor();
        QueryString _parametri;

        public PregledService(DBContext db, IMapper mapper, UserManager<User> UsrManger) : base(db, mapper, UsrManger)
        {
            _parametri = _context.HttpContext.Request.QueryString;
        }

        public override List<PregledVM> GetAll()
        {

            var preglediLista = _db.Pregled.ToList();
            
            if (!_context.HttpContext.Request.QueryString.HasValue)
            {
                preglediLista=preglediLista.Where(x => x.DoktorID == null && x.TehnicarID == null).ToList();
                return _mapper.Map<List<PregledVM>>(preglediLista);
            }
            else
            {

                var DoktorID = HttpUtility.ParseQueryString(_parametri.ToString()).Get("DoktorID");

                preglediLista = preglediLista.Where(x => x.DoktorID == int.Parse(DoktorID)).ToList();

                List<Pregled> nova = new List<Pregled>();

                var opis = HttpUtility.ParseQueryString(_parametri.ToString()).Get("Opis");

                if (opis == "Nalaz")
                {
                    var nalazLista = _db.Nalaz.ToList();

                    foreach (var i in nalazLista)
                    {
                        foreach (var j in preglediLista)
                        {
                            if (i.PregledID == j.ID)
                            {
                                nova.Add(j);
                            }
                        }
                    }
                }
                else
                {
                    var izvjestajLista = _db.Izvjestaj.ToList();

                    foreach (var i in izvjestajLista)
                    {
                        foreach (var j in preglediLista)
                        {
                            if (i.PregledID == j.ID)
                            {
                                nova.Add(j);
                            }
                        }
                    }
                }
                return _mapper.Map<List<PregledVM>>(preglediLista.Except(nova));
            }   
        }
    }
}
