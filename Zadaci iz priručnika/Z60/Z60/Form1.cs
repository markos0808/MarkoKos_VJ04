using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z60
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static Thread dretva;

        private void btnKreni_Click(object sender, EventArgs e)
        {
            Dretve d = new Dretve();
            dretva = new Thread(new ThreadStart(d.pocetak));
            dretva.Start();
            Random r = new Random();
            int sekunde = r.Next(0, 10000);
            Thread.Sleep(sekunde);
            dretva = new Thread(new ThreadStart(d.kraj));
            dretva.Start();

        }
    }
}
