using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z9
{
    class Ucitaj
    {
        string a;

        public Ucitaj(string adresa)
        {
            this.a = adresa;
        }

        public string ucitavanjeStranice(WebBrowser veb)
        {
            String link = a;
            veb.Navigate(link);
            return link;
        }
    }
}
