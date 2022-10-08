namespace MessagePack.MpDataExtractors
{
    internal class MpInt32DataExtractor : MpIntegerDataExtractor
    {
        public override byte[] Extract(object obj)
        {
            if (obj is not int int32)
            {
                throw new ArgumentException();
            }

            var data = BitConverter.GetBytes(int32);
            return data;
        }
    }
}
