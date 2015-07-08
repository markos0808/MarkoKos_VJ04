using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z4
{
    class Open
    {
        public Form1 newWindow { get; set; }
        
        public Open CreateNewWindow()
        {
            this.newWindow = new Form1();
            return this;
        }

        public Open OpenWindow()
        {
            this.newWindow.Show();
            return this;
        }
    }
}
