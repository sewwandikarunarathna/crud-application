using System;
using System.Collections.Generic;
using System.Text;

namespace bookApplication
{
    internal class BookProvider : IBookProvider

    {
        private readonly string bookContext;
        public BookProvider(BookContext bookContext )
        {
            this.bookContext = bookContext;
        }
        public Book Get(int id)
        {
            return bookContext.Books.Where(b => b.Id == id).FirstorDefault();
        }
    }
}
