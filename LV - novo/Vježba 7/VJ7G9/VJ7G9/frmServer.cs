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
using System.Net.Sockets;

namespace PIServer
{
    public partial class frmServer : Form
    {
        public Server Server
        {
            get;
            set;
        }

        public frmServer()
        {
            InitializeComponent();
            Server = new Server();
            Server.netSocketArgs.Completed += netSocketArgs_Completed;
        }

        void netSocketArgs_Completed(object sender, SocketAsyncEventArgs e)
        {
            if (Server.netSocketArgs.LastOperation == SocketAsyncOperation.Receive)
            {
                string message = UTF8Encoding.UTF8.GetString(
                    Server.netSocketArgs.Buffer, 0, e.BytesTransferred);
                WriteToLog(message);
                Server.netSocket.ReceiveAsync(Server.netSocketArgs);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Server.StartListening();
            WriteToLog("Server started.");
            btnStart.Enabled = false;
        }

        private void WriteToLog(string message)
        {
            txtLog.Invoke((MethodInvoker)delegate
            {
                txtLog.Text = message + Environment.NewLine + txtLog.Text;
            });
        }
    }
}
