using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestWorkForFreshcode.WebAPI.Contexts;
using TestWorkForFreshcode.WebAPI.Interfaces;
using TestWorkForFreshcode.WebAPI.Models;

namespace TestWorkForFreshcode.WebAPI.Repositories
{
    public class BookRepository : IRepository<Book>
    {
        private LibraryContext db;

        public BookRepository (LibraryContext libraryContext)
        {
            this.db = libraryContext;
        }

        public void Create(Book item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<Book> Get(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Book>> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Book item)
        {
            throw new NotImplementedException();
        }
    }
}
