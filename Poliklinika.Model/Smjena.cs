using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Poliklinika.Model
{
    public class Smjena
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("RasporedOsoblje")]
        public int RasporedOsobljeID { get; set; }
        public RasporedOsoblje RasporedOsoblje { get; set; }
    }
}
