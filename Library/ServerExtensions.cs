using MessagePack;

namespace Library
{
    public delegate TAnswer RequestHandler<TData, TAnswer>(TData data);

    public static class ServerExtensions
    {
        public static void Run<TData, TAnswer>(this IServer server, RequestHandler<TData, TAnswer> handler)
        {
            server.Run((serializedData) =>
            {
                var data = MessagePackSerializer.Deserialize<TData>(serializedData);
                var answer = handler(data);
                var serializedResponse = MessagePackSerializer.Serialize(answer);

                return serializedResponse;
            });
        }
    }
}
