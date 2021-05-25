﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoliklinikaAPI.ViewModels
{
    public class ObavezaVM
    {
        public int Id { get; set; }
        public int OsobljeID { get; set; }
        public int OdjelID { get; set; }
        public DateTime Datum { get; set; }
        public string Opis { get; set; }
    }
}