using MessagePack.MpObjects;

namespace MessagePack.MpObjectTypeExtractors
{
    internal class MpBooleanTypeExtractor : MpTypeExtractor
    {
        public override Type Extract(object obj)
        {
            if (obj is not bool boolean)
            {
                throw new ArgumentException();
            }

            var type = boolean ? typeof(MpTrue) : typeof(MpFalse);
            return type;
        }
    }
}
