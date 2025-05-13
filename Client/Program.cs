using Library;
using System.Net;
using System.Net.Sockets;
using static System.Console;

namespace Server
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var ip = IPAddress.Parse("127.0.0.1");
            var serverPort = 8080;
            var endPoint = new IPEndPoint(ip, serverPort);

            while (true)
            {
                Write("Message: ");

                var message = ReadLine();
                var answer = default(string);

                using (var client = new TcpClient())
                {
                    client.Connect(endPoint);

                    using (var stream = client.GetStream())
                    {
                        stream.Write(message);
                        answer = stream.Read<string>();
                    }
                }

                WriteLine($"Answer: {answer}");
                WriteLine();
            }
        }
    }
}
