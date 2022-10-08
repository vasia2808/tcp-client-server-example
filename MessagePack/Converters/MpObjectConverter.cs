using MessagePack.MpDataExtractors;
using MessagePack.MpObjects;
using MessagePack.MpObjectTypeExtractors;

namespace MessagePack.Converters
{
    internal class MpObjectConverter : IConverter
    {
        public object Convert(object obj)
        {
            var objType = obj.GetType();

            var mpObjectTypeExtractor = MpTypeExtractor.Get(obj);
            var mpObjType = mpObjectTypeExtractor.Extract(obj);

            var mpDataExtractor = MpDataExtractor.Get(objType);
            var mpData = mpDataExtractor.Extract(obj);

            var mpObjectCreator = MpObjectCreator.Get(mpObjType);
            var mpObj = mpObjectCreator.Create(mpData);

            return mpObj;
        }

        public object ConvertBack(object obj)
        {
            if (obj is not MpObject)
            {
                throw new ArgumentException();
            }

            throw new NotImplementedException();
        }
    }
}
