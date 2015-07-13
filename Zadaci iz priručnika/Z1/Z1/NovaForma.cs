using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z1
{
    class NovaForma
    {
        public NovaForma() { }
        public void Izracun()
        {
            Form1 nova = new Form1();
            nova.Show();
            Form1.brojForme = Application.OpenForms.Count;
            foreach (Form1 form in Application.OpenForms)
            {
                form.button1.Text=Form1.brojForme.ToString();
            }
        }
    }
}
