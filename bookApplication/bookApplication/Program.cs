using System;

namespace bookApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new BookContext("")
            var provider = new BookProvider(new BookContext(context));
            var book = provider.Get(1);
            Console.WriteLine($"Book name is {book.Name}");

            var sample = new BookRepo(context);
            sample.Create("4567", "Sherlock Holmes", "Arther");
        }
    }
}
