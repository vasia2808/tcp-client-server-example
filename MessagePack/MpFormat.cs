namespace MessagePack
{
    internal enum MpFormat : byte
    {
        True = 0xc2,
        False = 0xc3,
        Int32 = 0xd2,
        Float32 = 0xca,
        Float64 = 0xcb,
        Str16 = 0xdc,
    }
}