using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PIChat
{
    public class Server : NetObjects
    {
        public void StartListening()
        {
            netSocket.Bind(new IPEndPoint(IPAddress.Any, 8087));
            netSocket.ReceiveAsync(netSocketArgs);
        }
    }
}
