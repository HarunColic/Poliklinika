using System;
using System.Collections.Generic;
using System.Text;

namespace Poliklinika.Model
{
    public class Doktor:Osoblje
    {
        public int OdjelID { get; set; }
        public string Specijalizacija { get; set; }
        public string SubSpecijalizacija { get; set; }
    }
}
