using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket socket1 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            socket1.Connect(IPAddress.Parse("127.0.0.1"), 600);
            byte[] buffer = Encoding.ASCII.GetBytes(Console.ReadLine());
            socket1.Send(buffer);
            socket1.Close();
            Console.Read();
        }
    }
}
