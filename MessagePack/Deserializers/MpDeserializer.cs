using MessagePack.Converters;
using MessagePack.MpObjects;

namespace MessagePack.Deserializers
{
    internal class MpDeserializer : IDeserializer
    {
        public static readonly IConverter _converter = new MpObjectConverter();

        public object Deserialize(byte[] buffer)
        {
            throw new NotImplementedException();

            var mpObj = default(MpObject);
            var obj = _converter.ConvertBack(mpObj);

            return obj;
        }
    }
}
