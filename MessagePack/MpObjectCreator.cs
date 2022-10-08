using MessagePack.MpObjects;
using System.Collections.Concurrent;

namespace MessagePack
{
    internal class MpObjectCreator
    {
        private static readonly ConcurrentDictionary<Type, MpObjectCreator> _creators = new();

        public static MpObjectCreator Get(Type type)
        {
            var creator = _creators.GetOrAdd(type, Create);
            return creator;
        }

        private static MpObjectCreator Create(Type type)
        {
            var creator = new MpObjectCreator(type);
            return creator;
        }

        private readonly Type _type;

        private MpObjectCreator(Type type)
        {
            _type = type;
        }

        public MpObject Create(byte[] data)
        {
            var mpObject = default(MpObject);

            if (_type.IsSubclassOf(typeof(MpBoolean)))
            {
                var boolean = BitConverter.ToBoolean(data);
                mpObject = boolean ? MpBoolean.True : MpBoolean.False;
            }
            else
            {
                var parameters = new[] { data };
                var paramTypes = parameters.Select((param) => param.GetType()).ToArray();
                var ctor = _type.GetConstructor(paramTypes);

                mpObject = (MpObject)ctor.Invoke(parameters);
            }

            return mpObject;
        }
    }
}
