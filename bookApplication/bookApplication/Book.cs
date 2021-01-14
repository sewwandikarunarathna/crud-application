using System;
using System.Collections.Generic;
using System.Text;

namespace bookApplication
{
    [Table("Book")]
    internal class Book
    {
        public int Id { get; set; }
        [Column("book_number")]
        public int BookNumber { get; set; }
        [Column("book_name")]
        public string Name { get; set; }

        public string Author { get; set; }
    }
}
