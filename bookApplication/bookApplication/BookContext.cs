using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace bookApplication
{
   internal class BookContext : DbContext

    {
        private readonly string connectionString;
        private BookContext context;

        public BookContext(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public BookContext(BookContext context)
        {
            this.context = context;
        }

        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
