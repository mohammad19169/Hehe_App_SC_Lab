using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;

namespace server_hehe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TcpListener server = new TcpListener(8888);
            server.Start();
            Socket clientDoor=server.AcceptSocket();
            if (clientDoor.Connected ) {
                NetworkStream ns = new NetworkStream(clientDoor);
                Console.WriteLine("Server >> Hello Client!!");
                StreamWriter writer = new StreamWriter(ns);
                writer.WriteLine("server >>Hello Solax, You are connected!!");
                writer.Flush();
                while (true)
                {
                    StreamReader sr= new StreamReader(ns);
                    Console.WriteLine("Client>> "+sr.ReadLine());
                }
            }
            server.Stop();

        }
    }
}
