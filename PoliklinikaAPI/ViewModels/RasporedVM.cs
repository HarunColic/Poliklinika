using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoliklinikaAPI.ViewModels
{
    public class RasporedVM
    {
        public int ID { get; set; }
        public DateTime Datum { get; set; }
        public string Vrijeme { get; set; }
        public int DoktorID { get; set; }
        public int TehnicarID { get; set; }
        public int PregledID { get; set; }
    }
}
