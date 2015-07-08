using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z17
{
    class Racun
    {
        int brojRacuna;
        DateTime datumKreiranja;
        string prodavac;
        string nacinPlacanja;
        List<StavkaRacuna> stavke;

        public double iznosRacuna()
        {
            double suma = 0;
            foreach (StavkaRacuna stavka in stavke)
            {
                suma += stavka.IznosStavke();
            }
            return suma;
        }
    }
}
