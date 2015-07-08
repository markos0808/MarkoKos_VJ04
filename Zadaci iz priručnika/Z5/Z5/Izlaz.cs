using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z5
{
    class Izlaz
    {
        public Izlaz() { }
        public void Pozdrav()
        {
            MessageBox.Show("Pozdravna poruka!");
        }

        public void Zatvori()
        {
            Application.Exit();
        }
    }
}
