using System.Text;

namespace MessagePack.MpDataExtractors
{
    internal class MpStr16DataExtractor : MpStringDataExtractor
    {
        private static readonly Encoding _encoding = Encoding.UTF8;

        public override byte[] Extract(object obj)
        {
            if (obj is not string str)
            {
                throw new ArgumentException();
            }

            var data = _encoding.GetBytes(str);
            return data;
        }
    }
}
