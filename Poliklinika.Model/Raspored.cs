using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Poliklinika.Model
{
    public class Raspored
    {
        [Key]
        public int ID { get; set; }
        public DateTime Datum { get; set; } 
        public TimeSpan Vrijeme { get; set; }
        [ForeignKey("Osoblje")]
        public int OsobljeID { get; set; }
        public Osoblje Osoblje { get; set; }
        [ForeignKey("Pregled")]
        public int PregledID { get; set; }
        public Pregled Pregled { get; set; }


    }
}
