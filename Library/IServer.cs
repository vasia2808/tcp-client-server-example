namespace Library
{
    public delegate byte[] RequestHandler(byte[] data);

    public interface IServer
    {
        void Run(RequestHandler handler);
    }
}