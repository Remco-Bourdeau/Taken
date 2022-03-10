using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    [Table("Rekeningen")]
    public class Rekening
    {
        public Rekening() { }
        [StringLength(16)]
        public string RekeningNr { get; set; }
        [ForeignKey("Klant")]
        public int KlantNr { get; set; }
        [Required]
        public decimal Saldo { get; set; }
        [Required]
        public char Soort { get; set; }
        public Klant Klant { get; set; }


        public void Storten(decimal bedrag)
        {
            Saldo += bedrag;
        }
    }
}
