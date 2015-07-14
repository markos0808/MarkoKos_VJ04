using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z67
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIzracunaj_Click(object sender, EventArgs e)
        {
            string[] brojevi = this.txtZbrajaj.Text.Split('+');
            int n = 0;
            int m = 0;

            if (brojevi[0] == "nula") 
                n = 0;
            else if (brojevi[0] == "jedan") 
                n = 1;
            else if (brojevi[0] == "dva") 
                n = 2;
            else if (brojevi[0] == "tri") 
                n = 3;
            else if (brojevi[0] == "četiri") 
                n = 4;
            else if (brojevi[0] == "pet") 
                n = 5;

            if (brojevi[1] == "nula")
                m = 0;
            else if (brojevi[1] == "jedan")
                m = 1;
            else if (brojevi[1] == "dva")
                m = 2;
            else if (brojevi[1] == "tri")
                m = 3;
            else if (brojevi[1] == "četiri")
                m = 4;
            else if (brojevi[1] == "pet")
                m = 5;

            Zbroj zb = new Zbroj(n, m);

            if (zb.zbrajanje() == 0)
                txtZbrajaj.Text += "= nula ";
            if (zb.zbrajanje() == 1) 
                txtZbrajaj.Text += "= jedan ";
            if (zb.zbrajanje() == 2)
                txtZbrajaj.Text += "= dva ";
            if (zb.zbrajanje() == 3)
                txtZbrajaj.Text += "= tri ";
            if (zb.zbrajanje() == 4)
                txtZbrajaj.Text += "= četiri ";
            if (zb.zbrajanje() == 5)
                txtZbrajaj.Text += "= pet ";
            if (zb.zbrajanje() == 6)
                txtZbrajaj.Text += "= šest ";
            if (zb.zbrajanje() == 7)
                txtZbrajaj.Text += "= sedam ";
            if (zb.zbrajanje() == 8)
                txtZbrajaj.Text += "= osam ";
            if (zb.zbrajanje() == 9)
                txtZbrajaj.Text += "= devet ";
            if (zb.zbrajanje() == 10)
                txtZbrajaj.Text += "= deset ";
        }
    }
}
