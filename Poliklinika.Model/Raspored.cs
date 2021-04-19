using System;
using System.Collections.Generic;
using System.Text;

namespace Poliklinika.Model
{
    public class Raspored
    {
        public int ID { get; set; }
        public DateTime DatumOD { get; set; }
        public DateTime DatumDO { get; set; }
        public string Opis { get; set; }
        public string Dokument { get; set; }
    }
}
