using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z41
{
    class Niz
    {
        public Niz() { }

        public void napraviNiz(Form1 forma)
        {
            forma.lblBrojevi.Text = "";
            int a = 0;
            int b = 1;
            int suma = 1;

            for (int i = 0; i < int.Parse(forma.txtA.Text); i++)
            {
                forma.lblBrojevi.Text += suma.ToString() + ',';
                suma = a + b;
                a = b;
                b = suma;
            }
        }
    }
}
