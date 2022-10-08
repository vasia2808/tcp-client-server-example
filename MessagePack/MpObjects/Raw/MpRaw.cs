namespace MessagePack.MpObjects
{
    internal abstract class MpRaw : MpObject
    {
        public abstract uint Length { get; }
        public abstract byte[] Data { get; }

        public override byte[] ToBuffer()
        {
            return BitConverter.GetBytes(Length).Concat(Data).Prepend((byte)Format).ToArray();
        }
    }
}