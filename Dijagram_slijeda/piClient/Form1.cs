using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace piClient
{
    public partial class Form1 : Form
    {
        private Socket netSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        private SocketAsyncEventArgs netSocketClientArgs = new SocketAsyncEventArgs();
        private byte[] netSocketBuffer = new byte[1024];

        public Form1()
        {
            InitializeComponent();
            netSocket.ExclusiveAddressUse = false;
            //netSocketClientArgs.Completed+=netSocketClientArgs_Completed;
            netSocketClientArgs.SetBuffer(netSocketBuffer, 0, 1024);
        }

        void netSocketClientArgs_Completed(object sender, SocketAsyncEventArgs e)
        {
            if (netSocketClientArgs.LastOperation == SocketAsyncOperation.SendTo)
            {
                WriteToLog("destination: " + netSocketClientArgs.RemoteEndPoint.ToString() + "message: " + UTF8Encoding.UTF8.GetString(netSocketClientArgs.Buffer, 0, e.BytesTransferred));
            }
        }

        private void DestinationSet(IPEndPoint address)
        {
            netSocketClientArgs.RemoteEndPoint = address;
            WriteToLog("destination set: " + netSocketClientArgs.RemoteEndPoint.ToString());
        }


        private IPEndPoint GetDestination()
        {
            return new IPEndPoint(IPAddress.Parse(DestinationAddress.Text.Replace(" ", " ")), 8087);
        }


        private void WriteToLog(string message)
        {
            ReceiveContainer.Invoke((MethodInvoker)delegate
            {
                ReceiveContainer.Text = message + Environment.NewLine + ReceiveContainer.Text;
            });    
                
        }

        private void MessageSend(string message)
        {
            netSocketBuffer = UTF8Encoding.UTF8.GetBytes(message);
            netSocketClientArgs.SetBuffer(netSocketBuffer, 0, netSocketBuffer.Length);
            netSocket.SendToAsync(netSocketClientArgs);
        }


        private void ClearMessageInput()
        {
            MessageToSend.Clear();
        }


        private void DestinationSetAction_Click(object sender, EventArgs e)
        {
            DestinationSet(GetDestination());
        }

        private void MessageSendAction_Click(object sender, EventArgs e)
        {
            MessageSend(MessageToSend.Text);
            ClearMessageInput();
            WriteToLog("message sent");
        }
    }
}
