using Poliklinika.Model;
using PoliklinikaAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoliklinikaAPI.Interfaces
{
    public interface KorisnikInterface
    {
        public IList<KorisnikVM> GetAll();
        public KorisnikVM Get(int id);
        public KorisnikVM Insert(SignUpKorisnikVM korisnik);
        public KorisnikVM Update(int id, KorisnikVM Korisnik);
        public void Delete(int id);
    }
}
