using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z24
{
    class Skup
    {
        public Skup() { }

        public void skupBrojeva(Form1 forma)
        {
            string[] a = forma.txtA.Text.Split(',');
            string[] b = forma.txtB.Text.Split(',');

            foreach (string broj in a)
            {
                if (b.Contains(broj))
                {
                    forma.txtC.Text += broj + (',');
                }
            }
        }
    }
}
