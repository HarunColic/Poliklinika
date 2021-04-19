using System;
using System.Collections.Generic;
using System.Text;

namespace Poliklinika.Model
{
    public class Pregled
    {
        public int ID { get; set; }
        public int DoktorID { get; set; }
        public int KorisnikID { get; set; }
        public DateTime Datum { get; set; }
        public string Opis { get; set; }
    }
}
