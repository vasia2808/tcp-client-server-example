namespace MessagePack.MpObjects
{
    internal class MpStr16 : MpRaw
    {
        public MpStr16(byte[] data)
        {
            Data = data;
        }

        public override byte[] Data { get; }
        public override uint Length => (uint)Data.Length;
        public override MpFormat Format => MpFormat.Str16;

        public override byte[] ToBuffer()
        {
            return Data.Concat(BitConverter.GetBytes(Length)).Concat(Data).Prepend((byte)Format).ToArray();
        }
    }
}
