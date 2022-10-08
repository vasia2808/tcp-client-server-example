using System.Collections.Concurrent;

namespace MessagePack.MpObjectTypeExtractors
{
    internal abstract class MpTypeExtractor
    {
        private static readonly ConcurrentDictionary<Type, MpTypeExtractor> _extractors = new()
        {
            [typeof(bool)] = new MpBooleanTypeExtractor(),
            [typeof(int)] = new MpInt32TypeExtractor(),
            [typeof(string)] = new MpStr16TypeExtractor(),
        };

        public static MpTypeExtractor Get(object obj)
        {
            var type = obj.GetType();
            var extractor = _extractors.GetOrAdd(type, Create, obj);

            return extractor;
        }

        public abstract Type Extract(object obj);

        private static MpTypeExtractor Create(Type type, object obj)
        {
            throw new NotImplementedException();
        }
    }
}
