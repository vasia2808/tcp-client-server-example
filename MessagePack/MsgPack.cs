using MessagePack.Deserializers;
using MessagePack.Serializers;

namespace MessagePack
{
    public static class MsgPack
    {
        private static readonly ISerializer _serializer = new MpSerializer();
        private static readonly IDeserializer _deserializer = new MpDeserializer();

        public static byte[] Serialize(this object obj)
        {
            var buffer = _serializer.Serialize(obj);
            return buffer;
        }

        public static object Deserialize(this byte[] buffer)
        {
            var obj = _deserializer.Deserialize(buffer);
            return obj;
        }

        public static T Deserialize<T>(this byte[] buffer)
        {
            var obj = (T)_deserializer.Deserialize(buffer);
            return obj;
        }
    }
}
