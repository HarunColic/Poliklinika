using System;
using System.Collections.Generic;
using System.Text;

namespace Poliklinika.Model
{
    public class Osoblje: User
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrojRadneKnjizice { get; set; }
    }
}
