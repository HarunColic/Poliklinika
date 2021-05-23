using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoliklinikaAPI.ViewModels
{
    public class UplataVM
    {
        public int ID { get; set; }
        public int PregledID { get; set; }
        public float Iznos { get; set; }
        public DateTime DatumUplate { get; set; }
    }
}
