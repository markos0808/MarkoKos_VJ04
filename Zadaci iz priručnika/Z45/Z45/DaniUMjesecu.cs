using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z45
{
    class DaniUMjesecu
    {
        public DaniUMjesecu() { }

        public void dani(Form1 forma)
        {
            forma.listBoxDani.Items.Clear();
            for (int i = 1; i <= DateTime.DaysInMonth(DateTime.Now.Year, forma.listBoxMjesec.SelectedIndex + 1); i++)
            {
                forma.listBoxDani.Items.Add(i);
            }
        }
    }
}
