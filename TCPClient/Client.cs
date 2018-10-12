using System;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Net.Sockets;

namespace TCPClient
{
    public class Client
    {
        public void Start()
        {
            TcpClient client = new TcpClient("localhost", 7);

            while (true)
            {
                var stream = client.GetStream();
                var sr = new StreamReader(stream);
                var sw = new StreamWriter(stream);
                sw.AutoFlush = true;

                sw.WriteLine(Console.ReadLine());
                Console.WriteLine(sr.ReadLine());

            }
        }
    }
}