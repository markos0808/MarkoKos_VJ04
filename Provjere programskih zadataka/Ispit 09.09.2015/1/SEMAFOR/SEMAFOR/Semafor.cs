using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMAFOR
{
    public class Semafor
    {
        private int trenutnoStanje;
        public string[] stanja = new string[3];
        public bool silazno;


        public Semafor()
        {
            stanja[0] = "Crveno";
            stanja[1] = "Zuto";
            stanja[2] = "Zeleno";

            silazno = true;
            trenutnoStanje = 0;
        }


        public void PromijeniStanje()
        {
            if (trenutnoStanje == 0)
            {
                silazno = true;
                trenutnoStanje = 1;
            }

            else if (trenutnoStanje == 1 && silazno == true)
            {
                trenutnoStanje = 2;
            }

            else if (trenutnoStanje == 1 && silazno == false)
            {
                trenutnoStanje = 0;
            }

            else if (trenutnoStanje == 2)
            {
                silazno = false;
                trenutnoStanje = 1;
            }
        }


        public string DohvatiTrenutnoStanje()
        {
            return stanja[trenutnoStanje];
        }
    }
}
