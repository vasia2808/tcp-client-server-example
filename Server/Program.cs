using Library;
using System.Net;
using System.Text;
using static System.Console;

namespace Server
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var ip = IPAddress.Parse("127.0.0.1");
            var port = 8080;
            var endPoint = new IPEndPoint(ip, port);
            var server = new TcpServer(endPoint);
            
            server.Run((buffer) =>
            {
                var data = buffer.Skip(1).ToArray();
                var encoding = Encoding.UTF8;
                var str = encoding.GetString(data);

                WriteLine(str);

                return buffer;
            });
        }
    }
}