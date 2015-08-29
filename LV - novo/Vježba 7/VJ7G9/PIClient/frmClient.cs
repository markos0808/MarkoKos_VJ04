using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIChat;

namespace PIClient
{
    public partial class frmClient : Form
    {
        public Client Client
        {
            get;
            set;
        }

        public frmClient()
        {
            InitializeComponent();
            Client = new Client();

        }

        private void btnSetIp_Click(object sender, EventArgs e)
        {
            Client.SetDestinationIP(txtIP.Text);
            WriteToLog("IP address defined");
            txtMessage.Enabled = true;
            btnSend.Enabled = true;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Client.MessageSend(txtMessage.Text);
            WriteToLog("Message '" + txtMessage.Text + "' sent");
            txtMessage.Clear();
        }

        private void WriteToLog(string message)
        {
            txtLog.Text = message + Environment.NewLine + txtLog.Text;
        }
    }
}
