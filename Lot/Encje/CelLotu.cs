using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lot.Encje
{
    public class CelLotu
    {
        public int Id { get; set; }
        public string Kraj { get; set; }
        public string Miasto { get; set; }
        public string Lotnisko { get; set; }

        public virtual Lot Lot { get; set; }
        public virtual int LotId { get; set; }
    }
}
