using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z16
{
    class Petak
    {
        public Petak() { }

        public void broji(Form1 forma)
        {
            DayOfWeek petak = new DayOfWeek();
            DateTime sad = DateTime.Now;
            int brojac = 0;
            petak = sad.DayOfWeek;
            while (petak != DayOfWeek.Friday)
            {
                sad = sad.AddDays(1);
                petak = sad.DayOfWeek;
                brojac++;
            }
            forma.lblOdbr.Text = brojac.ToString();
        }
    }
}
