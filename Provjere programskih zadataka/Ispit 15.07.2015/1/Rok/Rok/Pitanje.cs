using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rok
{
    class Pitanje
    {
        public string TekstPitanja { get; set; }
        public string BrojBodova { get; set; }

        public Pitanje(string pitanje, string bodovi)
        {
            this.TekstPitanja = pitanje;
            this.BrojBodova = bodovi;
        }
    }
}
