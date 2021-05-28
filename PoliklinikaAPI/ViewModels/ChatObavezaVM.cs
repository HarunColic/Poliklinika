using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoliklinikaAPI.ViewModels
{
    public class ChatObavezaVM
    {
        public int ID { get; set; }
        public int ObavezaID { get; set; }
        public int OsobljeID { get; set; }
        public int AdminID { get; set; }
    }
}
