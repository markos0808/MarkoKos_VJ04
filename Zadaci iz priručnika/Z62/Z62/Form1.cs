using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z62
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int brojac;
        private void txtUpisi_KeyDown(object sender, KeyEventArgs e)
        {
            brojac++;
            Home home = new Home(brojac);
            home.homeRun(this, e);
        }
    }
}
