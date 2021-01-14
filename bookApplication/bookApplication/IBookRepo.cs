using System;
using System.Collections.Generic;
using System.Text;

namespace bookApplication
{
    internal interface IBookRepo
    {
        Book Create(int BookNumber,
            string Name,
            string Author);

        Book Update(Book book);

        void Delete(Book book);
    }
}
