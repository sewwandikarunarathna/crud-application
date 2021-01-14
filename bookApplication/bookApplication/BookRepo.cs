using System;
using System.Collections.Generic;
using System.Text;

namespace bookApplication
{
    internal class BookRepo : IBookRepo 

    {
        private readonly string bookContext;
        public BookRepo(BookContext bookContext)
        {
            this.bookContext = bookContext;
        }
        public Book Create(int BookNumber, string Name, string Author)
        {
            var response = bookContext.Add(new Book
            {
                BookNumber = BookNumber,
                Name = Name,
                Author = Author
            });
            bookContext.SaveChanges();
            return response.Entity;
        }

        public Book Update(Book book)
        {
            var response = bookContext.Update(book);
            bookContext.SaveChanges();
            return response.Entity;
        }

        public void Delete(Book book id)
        {
            bookContext.Remove(book);
            bookContext.SaveChanges();
        }
    }
}
