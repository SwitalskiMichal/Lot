using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lot.Encje
{
    public class Lot
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string nazwaLiniLotniczej { get; set; }
        public string nazwaSamolotu { get; set; }
        
        public virtual CelLotu CelLotu { get; set; }

        public virtual List<Pilot> Piloci { get; set; }
    }
}
