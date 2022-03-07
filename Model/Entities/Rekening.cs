using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    class Rekening
    {
        public string RekeningNr { get; set; }
        public int KlantNr { get; set; }
        public decimal Saldo { get; set; }
        public char Soort { get; set; }
        public Klant Klant { get; set; }


        public void Storten(decimal bedrag)
        {
            Saldo += bedrag;
        }
    }
}
