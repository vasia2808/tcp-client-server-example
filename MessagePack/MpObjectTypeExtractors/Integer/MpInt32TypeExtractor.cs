using MessagePack.MpObjects;

namespace MessagePack.MpObjectTypeExtractors
{
    internal class MpInt32TypeExtractor : MpTypeExtractor
    {
        public override Type Extract(object obj)
        {
            if (obj is not int)
            {
                throw new ArgumentException();
            }

            var type = typeof(MpInt32);
            return type;
        }
    }
}
