using System;

namespace TCPClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("From grams to ounces: toounces #");
            Console.WriteLine("From ounces to grams: tograms #");
            Client client = new Client();
            client.Start();
            Console.ReadLine();
        }
    }
}
