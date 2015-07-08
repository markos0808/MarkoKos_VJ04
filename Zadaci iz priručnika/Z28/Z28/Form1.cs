using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRnd_MouseHover(object sender, EventArgs e)
        {
            NovaLokacija nl = new NovaLokacija();
            nl.pomakni(this);
        }


    }
}
