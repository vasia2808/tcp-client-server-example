namespace MessagePack.MpObjects
{
    internal abstract class MpBoolean : MpObject
    {
        public static readonly MpBoolean False = new MpFalse();
        public static readonly MpBoolean True = new MpTrue();

        internal static MpObject Get(byte[] data)
        {
            var boolean = BitConverter.ToBoolean(data);
            var mpBoolean = boolean ? True : False;

            return mpBoolean;
        }
    }
}
