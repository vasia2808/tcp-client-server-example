using System.Net;
using System.Net.Sockets;

namespace Library
{
    public class TcpServer : IServer
    {
        private readonly TcpListener _listener;

        public TcpServer(IPEndPoint endPoint)
        {
            _listener = new TcpListener(endPoint);
        }

        public void Run(RequestHandler handler)
        {
            _listener.Start();

            while (true)
            {
                using (var client = _listener.AcceptTcpClient())
                using (var stream = client.GetStream())
                {
                    var data = stream.Read();
                    var answer = handler(data);
                    stream.Write(answer);
                }
            }
        }
    }
}
