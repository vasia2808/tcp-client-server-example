using MessagePack.MpObjects;

namespace MessagePack.MpObjectTypeExtractors
{
    internal class MpStr16TypeExtractor : MpStringTypeExtractor
    {
        public override Type Extract(object obj)
        {
            if (obj is not string)
            {
                throw new ArgumentException();
            }

            var type = typeof(MpStr16);
            return type;
        }
    }
}
