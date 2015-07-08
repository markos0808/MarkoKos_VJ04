using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z53
{
    class Mjesec
    {
        private int _id;
        private string _naziv;
        private int _brojDana;

        public Mjesec(int id, string naziv, int brojDana)
        {
            _id = id;
            _naziv = naziv;
            _brojDana = brojDana;
        }

        public void ispis()
        {
            Console.WriteLine(_naziv);
        }

        public int get_brojDana()
        {
            return _brojDana;
        }

        public static List<Mjesec> izracunSemestra(List<Mjesec> popis_mjeseca, Mjesec pocetni, Mjesec zavrsni)
        {
            List<Mjesec> mjeseci_u_rasponu = new List<Mjesec>();
            int iP = 0;
            int iZ = 0;

            for (int i = 0; i < 12; i++)
            {
                if (pocetni._naziv == popis_mjeseca[i]._naziv)
                    iP = i;
                if (zavrsni._naziv == popis_mjeseca[i]._naziv)
                    iZ = i;
            }

            for (int i = iP; i < iZ; i++)
            {
                mjeseci_u_rasponu.Add(popis_mjeseca[i]);
            }
            return mjeseci_u_rasponu;
        }

    }
}
