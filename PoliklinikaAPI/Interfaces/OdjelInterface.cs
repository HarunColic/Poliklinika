using Poliklinika.Model;
using PoliklinikaAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoliklinikaAPI.Interfaces
{
    public interface OdjelInterface
    {
        public List<Odjel> GetAll();
        public Odjel Get(int id);
        public Odjel Insert(OdjelVM odjel);
        public Odjel Update(int id, OdjelVM odjel);
        public void Delete(int id);
    }
}
