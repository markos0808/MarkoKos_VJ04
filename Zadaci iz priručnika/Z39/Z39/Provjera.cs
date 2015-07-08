using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z39
{
    class Provjera
    {
        public Provjera() { }

        public void promjenaTeksta(Form1 forma)
        {
            Random r = new Random();
            string tekst = (r.Next(0, 100).ToString());
            forma.lblTekst.Text = tekst.ToString();
        }
    }
}
