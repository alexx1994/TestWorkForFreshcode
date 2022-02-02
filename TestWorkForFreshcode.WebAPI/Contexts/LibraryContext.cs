using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestWorkForFreshcode.WebAPI.Models;

namespace TestWorkForFreshcode.WebAPI.Contexts
{
    public class LibraryContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {
            //Создаем базу данных при первом обращении
            Database.EnsureCreated();
        }
    }
}
