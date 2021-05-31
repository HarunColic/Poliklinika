using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoliklinikaAPI.ViewModels
{
    public class PregledVM
    {
        public int ID { get; set; }
        public int? DoktorID { get; set; }
        public int KorisnikID { get; set; }
        public DateTime Datum { get; set; }
        public string Opis { get; set; }
        public int? TehnicarID { get; set; }
        public int OdjelID { get; set; }
    }
}
