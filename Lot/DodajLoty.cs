using Lot.Encje;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Lot
{
    public class DodajLoty
    {
        private LotContext lotContext;

        public DodajLoty(LotContext lotContext)
        {
            this.lotContext = lotContext;
        }

        public  void DodajDane()
        {
            if(lotContext.Database.CanConnect())
            {
                if (!lotContext.Loty.Any())
                {
                    WstawRekordy();
                }
            }
        }

        private void WstawRekordy()
        {
            var loty = new List<Encje.Lot>
            {
                new Encje.Lot
                {
                    nazwaLiniLotniczej = "Lufthansa",
                    nazwaSamolotu = "Airbus A350 XWB",
                    Data = DateTime.Now.AddDays(20),
                    CelLotu = new CelLotu
                    {
                        Kraj = "France",
                        Miasto = "Paris",
                        Lotnisko = "Charles de Gaulle Airport",
                    },
                    Piloci = new List<Pilot>
                    {
                        new Pilot
                        {
                            Imie = "Miikka",
                            Nazwisko = "Raita",
                            KrajPochodzenia = "Finland"
                        }
                    }
                },

                new Encje.Lot
                {
                    nazwaLiniLotniczej = "American Airlines",
                    nazwaSamolotu = "Boeing 737 NG/737 MAX",
                    Data = DateTime.Now.AddDays(20),
                    CelLotu = new CelLotu
                    {
                        Kraj = "China",
                        Miasto = "Guangzhou",
                        Lotnisko = "Guangzhou Baiyun International Airport",
                    },
                    Piloci = new List<Pilot>
                    {
                        new Pilot
                        {
                            Imie = "Severino",
                            Nazwisko = "Capon",
                            KrajPochodzenia = "Italy"
                        },
                        new Pilot
                        {
                            Imie = "Mohamed",
                            Nazwisko = "Mestiri",
                            KrajPochodzenia = "Iran"
                        }
                    }
                }
            };
            lotContext.AddRange(loty);
            lotContext.SaveChanges();
        }
    }
}
