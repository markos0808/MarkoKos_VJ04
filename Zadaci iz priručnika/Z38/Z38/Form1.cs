using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z38
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public void setLabel(Label label, Random r)
        {
            label.Text = r.Next().ToString();
            int x = r.Next(0, this.Width);
            int y = r.Next(0, this.Height);
            label.Location = new Point(x, y);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                timer1.Start();
            }

            else if (timer1.Enabled == true)
            {
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Koincidencija kc = new Koincidencija();
            kc.slucajno(this);
        }
    }
}
