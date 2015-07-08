using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBarR_Scroll(object sender, EventArgs e)
        {
            Bojanje b = new Bojanje();
            b.Boja(this);

        }

        private void trackBarG_Scroll(object sender, EventArgs e)
        {
            Bojanje b = new Bojanje();
            b.Boja(this);
        }

        private void trackBarB_Scroll(object sender, EventArgs e)
        {
            Bojanje b = new Bojanje();
            b.Boja(this);
        }
    }
}
