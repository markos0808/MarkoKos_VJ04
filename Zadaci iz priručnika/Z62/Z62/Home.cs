using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z62
{
    class Home
    {
        int brojac;

        public Home(int n)
        {
            this.brojac = n;
        }

        public void homeRun(Form1 forma, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Home")
            {
                brojac++;
            }

            if (brojac == 5)
            {
                forma.txtUpisi.Text += "Home Run!";
                brojac = 0;
            }
        }
    }
}
