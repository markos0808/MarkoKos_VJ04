using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z17
{
    class StavkaRacuna
    {
        int idStavka;
        Artikl artikl;
        float kolicina;

        public float IznosStavke()
        {
            return artikl.jedinicnaCijena * kolicina;
        }
    }
}
