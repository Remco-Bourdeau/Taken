using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public abstract class Artikel
    {
        public int ArtikelId { get; set; }
        public string Naam { get; set; }
    }
}
