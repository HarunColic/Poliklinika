using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoliklinikaAPI.ViewModels
{
    public class KonsultacijeVM
    {
        public int ID { get; set; }
        public int KorisnikID { get; set; }
        public int DoktorID { get; set; }
    }
}
