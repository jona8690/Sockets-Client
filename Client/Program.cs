using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    class Program
    {
        private static bool programRunning = true;
        static void Main(string[] args)
        {
            TcpClient client = new TcpClient("127.0.0.1", 5000);
            StreamReader sr = new StreamReader(client.GetStream());
            StreamWriter sw = new StreamWriter(client.GetStream());
            sw.AutoFlush = true;



            //Ex2 & 3
            while (programRunning)
            {
                string data = sr.ReadLine();
                if (data == "ready")
                {
                    sw.WriteLine(Console.ReadLine());
                    data = sr.ReadLine();
                    Console.WriteLine(data);
                }
            }

            //Ex1
            //sw.WriteLine("Hello server");
            //string data = sr.ReadLine();

            //while (data != null)
            //{
            //    Console.WriteLine(data);
            //    data = sr.ReadLine();
            //}
        }
    }
}
