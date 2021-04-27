using Poliklinika.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoliklinikaAPI.Interfaces
{
    public interface OdjelInterface
    {
        public IList<Odjel> GetAll();
        public Odjel Get();
        public Odjel Create();
        public Odjel Update();
        public Odjel Delete();
    }
}
