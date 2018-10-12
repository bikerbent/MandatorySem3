using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using Components;

namespace TCPServer
{
    class Server
    {
        public void Start()
        {
            TcpListener serverListener = new TcpListener(IPAddress.Loopback, 7);
            serverListener.Start();
            while (true)
            {
                var client = serverListener.AcceptTcpClient();
                Task.Run(() => DoClient(client));
            }
        }

        private void DoClient(TcpClient socket)
        {
            while (socket.Connected)
            {
                var Stream = socket.GetStream();
                var sr = new StreamReader(Stream);
                var sw = new StreamWriter(Stream);
                sw.AutoFlush = true;

                string[] Strings;
                Strings = sr.ReadLine().Split(' ');
                string serverText = Strings[0].ToUpper();
                if (serverText == "TOGRAMS")
                {
                    double weight = double.Parse(Strings[1]);
                    double result = Converts.ConvertToGrams(weight);
                    sw.WriteLine(result);
                }
                else if(serverText == "TOOUNCES")
                {
                    double weight = double.Parse(Strings[1]);
                    double result = Converts.ConvertToOunces(weight);
                    sw.WriteLine(result);
                }
            }
        }

    }
}
