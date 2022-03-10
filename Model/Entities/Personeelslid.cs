using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Personeelslid
    {
        [Key]
        public int PersoneelsNr { get; set; }
        public string Voornaam { get; set; }
        public int? ManagerNr { get; set; }
        //public virtual ICollection<Personeelslid> Ondergeschikten { get; set; } = new List<Personeelslid>();
        //[InverseProperty("Ondergeschikten")]
        //[ForeignKey("ManagerNr")]
        //public virtual Personeelslid Manager { get; set; }
        
    }
}
