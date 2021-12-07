using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Socket socket1 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                socket1.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 600));
                socket1.Listen(9);
                Socket client = socket1.Accept();
                NetworkStream ns = new NetworkStream(client);
                StreamReader sr = new StreamReader(ns);
                Console.WriteLine(sr.ReadToEnd());
               //sr.Close;
               //ns.Close;
                socket1.Shutdown(SocketShutdown.Receive);
                client.Shutdown(SocketShutdown.Receive);
            }
            catch (SocketException exc)
            {
                Console.WriteLine("error");

            }
            Console.Read();
        }
    }
}
