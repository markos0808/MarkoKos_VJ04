using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z18
{
    class Semestar
    {
        Mjesec pocetakSemestra;
        Mjesec zavrsetakSemestra;
        List<Mjesec> izmedju;
        public List<Mjesec> Izracunaj()
        {
            for (Mjesec i = pocetakSemestra; i.redniBroj < zavrsetakSemestra.redniBroj; i.redniBroj++)
            {
                izmedju.Add(i);
            }
            return izmedju;
        }
    }
}
