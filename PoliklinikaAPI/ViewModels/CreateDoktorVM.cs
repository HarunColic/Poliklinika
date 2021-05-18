using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoliklinikaAPI.ViewModels
{
    public class CreateDoktorVM
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Spol { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string BrojRadneKnjizice { get; set; }
        public string Specijalizacija { get; set; }
        public string SubSpecijalizacija { get; set; }
        public int OdjelID { get; set; }
    }
}
