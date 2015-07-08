using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z15
{
    class Petak13
    {
        public Petak13() { }

        public void Izracun(Form1 forma)
        {
            int brojac = 0;
            DateTime a = new DateTime(int.Parse(forma.txtGodina.Text), 1, 1);
            int b = int.Parse(forma.txtGodina.Text) + 1;
            while (a.Year != b)
            {
                a = a.AddDays(1);
                if (a.Day == 13 & a.DayOfWeek == DayOfWeek.Friday)
                {
                    brojac++;
                }
            }
            forma.txtGodina.Text = brojac.ToString();
        }
    }
}
