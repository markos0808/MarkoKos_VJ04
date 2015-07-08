using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open window = new Open();
            window.CreateNewWindow();
            window.newWindow.MdiParent = this.MdiParent;
            window.OpenWindow();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit.CloseApplication();
        }
    }
}
