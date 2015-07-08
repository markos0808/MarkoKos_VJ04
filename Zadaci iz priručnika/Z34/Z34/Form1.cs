using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.setLabelLocation();
        }

        private void setLabelLocation()
        {
            int x = (this.Width / 2) - (this.lblKvadrant.Width / 2) - 10;
            int y = (this.Height / 2) - (this.lblKvadrant.Height / 2) - 25;
            this.lblKvadrant.Location = new Point(x, y);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Strane str = new Strane();
            str.straneSvijeta(this, e);
        }


    }
}
