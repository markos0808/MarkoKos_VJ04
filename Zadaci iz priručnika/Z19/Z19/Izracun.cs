using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z19
{
    class Izracun
    {
        public Izracun() { }

        public void racun(Form1 forma)
        {
            string a = forma.txtA.Text;
            string b = forma.txtB.Text;
            int n = 0;
            int m = 0;

            try
            {
                n = int.Parse(a);
                m = int.Parse(b);
            }

            catch (Exception)
            {
                MessageBox.Show("Format nije dobar!"); 
            }

            if (m == 0)
            {
                MessageBox.Show("Djelitelj mora biti != od 0!");
            }

            int rezultat = n / m;
            forma.txtRez.Text = rezultat.ToString();
        }
    }
}
