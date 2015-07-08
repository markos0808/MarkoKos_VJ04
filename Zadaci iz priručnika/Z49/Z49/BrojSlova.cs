using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z49
{
    class BrojSlova
    {
        public BrojSlova() { }

        public List<Slovo> PobrojiSlova(string recenica)
        {
            List<Slovo> slova = new List<Slovo>();
            List<char> slovaRecenice = recenica.ToList<char>();
            slovaRecenice.Sort();

            for (int i = 0; i < slovaRecenice.Count; i++)
            {
                Slovo trenutno = new Slovo(slovaRecenice[i]);
                bool ima = false;
                foreach (Slovo slovo in slova)
                {
                    if (slovo.znak == trenutno.znak)
                    {
                        slovo.brojPonavljanja++;
                        ima = true;
                        break;
                    }
                }
                if (!ima)
                {
                    slova.Add(trenutno);
                }
            }
            return slova;
        }
    }
}
