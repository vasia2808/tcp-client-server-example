using MessagePack;
using System.Net.Sockets;

namespace Library
{
    public static class StreamExtensions
    {
        public static void Write<T>(this Stream stream, T data)
        {
            var serializedData = MessagePackSerializer.Serialize(data);
            stream.Write(serializedData);
        }

        public static byte[] Read(this Stream stream)
        {
            if (stream is NetworkStream networkStream)
            {
                return Read(networkStream);
            }

            var data = new byte[stream.Length];
            stream.Read(data, 0, data.Length);

            return data;
        }

        public static byte[] Read(this NetworkStream stream)
        {
            const int bufferLength = 256;

            var buffer = new byte[bufferLength];
            var data = new List<byte>();

            do
            {
                var length = stream.Read(buffer, 0, bufferLength);
                data.AddRange(buffer.AsSpan(0, length).ToArray());
            }
            while (stream.DataAvailable);

            return data.ToArray();
        }

        public static T Read<T>(this Stream stream)
        {
            var serializedData = stream.Read();
            var data = MessagePackSerializer.Deserialize<T>(serializedData);

            return data;
        }
    }
}
