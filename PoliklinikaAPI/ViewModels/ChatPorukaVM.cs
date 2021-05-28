using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoliklinikaAPI.ViewModels
{
    public class ChatPorukaVM
    {
        public int ID { get; set; }
        public int OsobljeID { get; set; }
        public int ChatObavezaID { get; set; }
        public string Poruka { get; set; }
    }
}
