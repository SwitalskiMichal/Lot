using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lot.Controllers.Modele
{
    public class LotyDetailsDto
    {
        public DateTime Data { get; set; }
        public string nazwaLiniLotniczej { get; set; }
        public string nazwaSamolotu { get; set; }
        public string Kraj { get; set; }
        public string Miasto { get; set; }
        public string Lotnisko { get; set; }
    }
}
