using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace Dijagram_slijeda
{
    public partial class Form1 : Form
    {

        private Socket netSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        private SocketAsyncEventArgs netSocketServerArgs = new SocketAsyncEventArgs();
        private byte[] netSocketBuffer = new byte[1024];

        private void WriteToLog(string message)
        {
            ReceiveContainer.Invoke((MethodInvoker)delegate
            {
                ReceiveContainer.Text = message + Environment.NewLine + ReceiveContainer.Text;
            });
        }

        public Form1()
        {
            InitializeComponent();
            netSocket.ExclusiveAddressUse = false;
            netSocketServerArgs.Completed += netSocketServerArgs_Completed;
            netSocketServerArgs.SetBuffer(netSocketBuffer, 0, 1024);
        }

        private void StartListening()
        {
            netSocket.Bind(new IPEndPoint(IPAddress.Any, 8087));
            netSocket.ReceiveAsync(netSocketServerArgs);
            WriteToLog("listening");
        }
        void netSocketServerArgs_Completed(object sender, SocketAsyncEventArgs e)
        {
            if (netSocketServerArgs.LastOperation == SocketAsyncOperation.Receive)
            {
                WriteToLog("message: " + UTF8Encoding.UTF8.GetString(netSocketServerArgs.Buffer, 0, e.BytesTransferred));
                netSocket.ReceiveAsync(netSocketServerArgs);
            }
        }

        private void StartListeningAction_Click(object sender, EventArgs e)
        {
            StartListening();
        }
    }
}
