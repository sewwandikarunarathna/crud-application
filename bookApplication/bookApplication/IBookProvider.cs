namespace bookApplication
{
    internal interface IBookProvider
    {
        Book Get(int id);
    }
}