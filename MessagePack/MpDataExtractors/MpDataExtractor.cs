using System.Collections.Concurrent;

namespace MessagePack.MpDataExtractors
{
    internal abstract class MpDataExtractor
    {
        private static readonly ConcurrentDictionary<Type, MpDataExtractor> _extractors = new()
        {
            [typeof(bool)] = new MpBooleanDataExtractor(),
            [typeof(int)] = new MpInt32DataExtractor(),
            [typeof(string)] = new MpStr16DataExtractor(),
        };

        public static MpDataExtractor Get(Type type)
        {
            var extractor = _extractors.GetOrAdd(type, Create);
            return extractor;
        }

        public abstract byte[] Extract(object obj);

        private static MpDataExtractor Create(Type arg)
        {
            throw new NotImplementedException();
        }
    }
}
