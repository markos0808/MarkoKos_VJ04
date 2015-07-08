using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z35
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.progressBarX.Minimum = 0;
            this.progressBarX.Maximum = this.Width;
            this.progressBarY.Minimum = 0;
            this.progressBarY.Maximum = this.Height;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Lokacija lok = new Lokacija();
            lok.location(this, e);
        }


    }
}
