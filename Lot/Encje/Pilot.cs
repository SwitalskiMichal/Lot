using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lot.Encje
{
    public class Pilot
    {
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string KrajPochodzenia { get; set; }

        public virtual Lot Lot { get; set; }
        public virtual int LotId { get; set; }
    }
}
