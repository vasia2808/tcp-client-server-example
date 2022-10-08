namespace MessagePack.Converters
{
    internal interface IConverter
    {
        object Convert(object obj);
        object ConvertBack(object obj);
    }
}