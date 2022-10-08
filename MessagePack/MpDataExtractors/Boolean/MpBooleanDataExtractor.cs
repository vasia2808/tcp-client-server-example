namespace MessagePack.MpDataExtractors
{
    internal class MpBooleanDataExtractor : MpDataExtractor
    {
        public override byte[] Extract(object obj)
        {
            if (obj is not bool boolean)
            {
                throw new ArgumentException();
            }

            var data = BitConverter.GetBytes(boolean);
            return data;
        }
    }
}
