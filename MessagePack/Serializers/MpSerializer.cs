using MessagePack.Converters;
using MessagePack.MpObjects;

namespace MessagePack.Serializers
{
    internal class MpSerializer : ISerializer
    {
        private static readonly IConverter converter = new MpObjectConverter();

        public byte[] Serialize(object obj)
        {
            var mpObject = (MpObject)converter.Convert(obj);
            var buffer = mpObject.ToBuffer();

            return buffer;
        }
    }
}
