using Poliklinika.Model;
using PoliklinikaAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoliklinikaAPI.Interfaces
{
    public interface NalazInterface
    {
        public List<Nalaz> GetAll();
        public Nalaz Get(int id);
        public Nalaz Insert(NalazVM nalaz);
        public Nalaz Update(int id, NalazVM nalaz);
        public void Delete(int id);
    }
}
