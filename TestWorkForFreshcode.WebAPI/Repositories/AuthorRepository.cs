using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestWorkForFreshcode.WebAPI.Contexts;
using TestWorkForFreshcode.WebAPI.Interfaces;
using TestWorkForFreshcode.WebAPI.Models;

namespace TestWorkForFreshcode.WebAPI.Repositories
{
    public class AuthorRepository : IRepository<Author>
    {
        private LibraryContext db;

        public AuthorRepository(LibraryContext libraryContext)
        {
            this.db = libraryContext;
        }

        public async Task<Author> Get(int Id)
        {
            return await db.Authors.FindAsync(Id);
        }

        public async Task<IEnumerable<Author>> GetAll()
        {
            return await db.Authors.ToListAsync();
        }

        public void Create(Author author)
        {
            db.Authors.Add(author);
            db.SaveChangesAsync();
        }

        public void Update(Author author)
        {
            db.Entry(author).State = EntityState.Modified;
            db.SaveChangesAsync();
        }

        public void Delete(int Id)
        {
            Author author = db.Authors.Find(Id);
            if (author != null)
            {
                db.Entry(author).State = EntityState.Deleted;
                db.SaveChangesAsync();
            }
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
