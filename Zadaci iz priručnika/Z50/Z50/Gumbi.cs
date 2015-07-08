using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z50
{
    class Gumbi
    {
        public Gumbi() { }

        public void napraviGumbe(Form1 forma)
        {
            int broj = int.Parse(forma.txtBrojGumbeka.Text);
            Random r = new Random();

            for (int i = 0; i < broj; i++)
            {
                Button gumb = new Button();
                int x = r.Next(0, forma.Width);
                int y = r.Next(0, forma.Height);
                gumb.Location = new Point(x, y);
                gumb.Text = r.Next(0, 100).ToString();
                gumb.Click += gumb_Click;
                forma.Controls.Add(gumb);
            }
        }

        void gumb_Click(object sender, EventArgs e)
        {
            Button drugiGumb = (Button)sender;
            MessageBox.Show("Lokacija: " + drugiGumb.Location.X + "," + drugiGumb.Location.Y);
        }


    }
}
