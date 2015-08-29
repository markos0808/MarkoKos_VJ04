using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace PIChat
{
    public class NetObjects
    {
        public Socket netSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        public SocketAsyncEventArgs netSocketArgs = new SocketAsyncEventArgs();
        public byte[] netSocketBuffer = new byte[1024];


        public NetObjects()
        {
            netSocketArgs.SetBuffer(netSocketBuffer, 0, 1024);
        }
    }
}
