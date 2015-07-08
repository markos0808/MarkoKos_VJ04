using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z60
{
    class Dretve
    {
        public Dretve() { }

        public void pocetak()
        {
            MessageBox.Show(DateTime.Now.ToString(), "Pocetak");
        }

        public void kraj()
        {
            MessageBox.Show(DateTime.Now.ToString(), "Kraj");
        }
    }
}
