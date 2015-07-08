using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z13
{
    class Brojevi
    {
        public Brojevi() { }

        public void sortiranjeBrojeva(Form1 forma)
        {
            string[] brojevi = forma.txtBrojevi.Text.Split(',');
            ArrayList lista = new ArrayList();
            forma.txtBrojevi.Clear();
            foreach (string broj in brojevi)
            {
                lista.Add(int.Parse(broj));
            }
            lista.Sort(null);
            foreach (int broj in lista)
            {
                forma.txtBrojevi.Text += broj.ToString() + ",";
            }
        }
    }
}
