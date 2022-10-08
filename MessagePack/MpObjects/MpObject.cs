namespace MessagePack.MpObjects
{
    internal abstract class MpObject
    {
        public abstract MpFormat Format { get; }

        public virtual byte[] ToBuffer()
        {
            var buffer = new [] { (byte)Format };
            return buffer;
        }
    }
}
