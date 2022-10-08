namespace MessagePack.MpObjects
{
    internal abstract class MpInteger : MpObject
    {
        public abstract byte[] Value { get; }

        public override byte[] ToBuffer()
        {
            return Value.Prepend((byte)Format).ToArray();
        }
    }
}
