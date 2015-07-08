using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z30
{
    class Mjesec
    {
        public Mjesec() { }

        public void pregledMjeseca(Form1 forma)
        {
            int lista = (int)forma.cboxMjesec.SelectedItem;
            forma.monthCalendar.SetDate(new DateTime(DateTime.Now.Year, lista, DateTime.Now.Day));

        }
    }
}
