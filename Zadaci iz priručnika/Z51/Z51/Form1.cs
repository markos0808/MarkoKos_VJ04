using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z51
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPresjek_Click(object sender, EventArgs e)
        {
            int a = 0, b = 0, c = 0, d = 0;

            try
            {
                int.TryParse(txt1.Text, out a);
                int.TryParse(txt2.Text, out b);
                int.TryParse(txt3.Text, out c);
                int.TryParse(txt4.Text, out d);
            }

            catch
            {
                MessageBox.Show("Nisu uneseni brojevi!");
            }

            Intervali i = new Intervali(a, b, c, d);
            MessageBox.Show(i.presjekSkupova().ToString());
        }
    }
}
