using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PIChat
{
    public class Client : NetObjects
    {
        public void MessageSend(string message)
        {
            netSocketBuffer = UTF8Encoding.UTF8.GetBytes(message);
            netSocketArgs.SetBuffer(netSocketBuffer, 0, netSocketBuffer.Length);
            netSocket.SendToAsync(netSocketArgs);
        }

        public void SetDestinationIP(string ip)
        {
            IPEndPoint address = new IPEndPoint(IPAddress.Parse(ip), 8087);
            netSocketArgs.RemoteEndPoint = address;
        }
    }
}
