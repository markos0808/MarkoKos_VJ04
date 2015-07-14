using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_3
{
    class Automobil: Vozilo
    {
        public Automobil(string naziv, string tip)
        {
            this.Naziv = naziv;
            this.TipVozila = tip;
        }
    }
}
