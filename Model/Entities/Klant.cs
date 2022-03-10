using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    [Table("Klanten")]
    public class Klant
    {
        public Klant()
        {
            Rekeningen = new List<Rekening>();
        }
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int KlantNr { get; set; }
        [Required]
        [StringLength(20)]
        public string Voornaam { get; set; }
        public ICollection<Rekening> Rekeningen { get; set; }
    }
}
