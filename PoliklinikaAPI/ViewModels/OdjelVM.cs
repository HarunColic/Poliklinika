using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoliklinikaAPI.ViewModels
{
    public class OdjelVM
    {
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public byte[] Slika { get; set; }
    }
}
