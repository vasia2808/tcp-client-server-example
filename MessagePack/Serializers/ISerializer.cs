namespace MessagePack.Serializers
{
    internal interface ISerializer
    {
        public byte[] Serialize(object obj);
    }
}
