using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoliklinikaAPI.ViewModels
{
    public class KonsultacijePorukaVM
    {
        public int ID { get; set; }
        public int KonsultacijeID { get; set; }
        public int UserID { get; set; }
        public string Poruka { get; set; }
    }
}
