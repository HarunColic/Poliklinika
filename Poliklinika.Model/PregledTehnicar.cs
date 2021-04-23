using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Poliklinika.Model
{
    public class PregledTehnicar
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Pregled")]
        public int PregledID { get; set; }
        public Pregled Pregled { get; set; }
        [ForeignKey("Tehnicar")]
        public int TehnicarID { get; set; }
        public Tehnicar Tehnicar { get; set; }
    }
}
