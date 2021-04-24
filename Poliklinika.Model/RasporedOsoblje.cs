using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Poliklinika.Model
{
    public class RasporedOsoblje
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Osoblje")]
        public int OsobljeID { get; set; }
        public Osoblje Osoblje { get; set; }
        [ForeignKey("Raspored")]
        public int RasporedID { get; set; }
        public Raspored Raspored { get; set; }
    }
}
