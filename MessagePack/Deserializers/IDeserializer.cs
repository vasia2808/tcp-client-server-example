namespace MessagePack.Deserializers
{
    public interface IDeserializer
    {
        public object Deserialize(byte[] buffer);
    }
}
