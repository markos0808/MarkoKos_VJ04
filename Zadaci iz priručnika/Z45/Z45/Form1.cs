using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z45
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 1; i <= 12; i++)
            {
                listBoxMjesec.Items.Add(i);
            }
        }

        private void listBoxMjesec_SelectedIndexChanged(object sender, EventArgs e)
        {
            DaniUMjesecu dum = new DaniUMjesecu();
            dum.dani(this);
        }
    }
}
