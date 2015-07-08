using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            Pomicanje_gumba pG = new Pomicanje_gumba();
            pG.Pomakni(this);
        }


    }
}
