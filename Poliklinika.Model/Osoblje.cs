using System;
using System.Collections.Generic;
using System.Text;

namespace Poliklinika.Model
{
    public class Osoblje: User
    {
        public string BrojRadneKnjizice { get; set; }
        public string Zanimanje { get; set; }
    }
}
