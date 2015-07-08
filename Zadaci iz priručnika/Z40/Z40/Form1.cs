using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z40
{
    public partial class Form1 : Form
    {
        public ProgressBar[] pb = new ProgressBar[10];
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                pb[i] = new ProgressBar();
                pb[i].Maximum = 100;
                pb[i].Minimum = 0;
                pb[i].Location = new Point(0, i * 25);
                this.Controls.Add(pb[i]);
            }
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PBA p = new PBA();
            p.vrijednost(this);
        }
    }
}
