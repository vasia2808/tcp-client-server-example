namespace MessagePack.MpObjects
{
    internal class MpInt32 : MpInteger
    {
        public MpInt32(byte[] value)
        {
            Value = value;
        }

        public override byte[] Value { get; }
        public override MpFormat Format => MpFormat.Int32;
    }
}
