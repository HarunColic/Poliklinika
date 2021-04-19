using System;
using System.Collections.Generic;
using System.Text;

namespace Poliklinika.Model
{
    public class Uplata
    {
        public int ID { get; set; }
        public int PregledID { get; set; }
        public float Iznos { get; set; }
        public DateTime DatumUplate { get; set; }
    }
}
