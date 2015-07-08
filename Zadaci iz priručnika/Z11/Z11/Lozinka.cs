using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z11
{
    class Lozinka
    {
        string a, b;

        public Lozinka(string prvi, string drugi)
        {
            this.a = prvi;
            this.b = drugi;
        }

        public void provjeriLozinke()
        {
            if (a.CompareTo(b) != 0)
            {
                MessageBox.Show("Lozinke nisu jednake!");
            }

            int brojac=0;

            for (int i = 0; i < a.Length; i++)
            {
                if (char.IsLetter(a[i]) && char.IsUpper(a[i]))
                {
                    ++brojac;
                }
            }

            if (brojac < 3)
            {
                MessageBox.Show("Nema dovoljno velikih slova!");
            }

            if (!a.Contains('#') || !a.Contains('$') || !a.Contains('%'))
            {
                MessageBox.Show("Niste koristili znakove iz liste!");
            }

            if(a==b)
            {
                MessageBox.Show("Lozinke su jednake!");
            }

    
        }
    }
}
