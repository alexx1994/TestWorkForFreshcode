using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestWorkForFreshcode.WebAPI.Interfaces
{
    interface IRepository<T> : IDisposable
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(int Id);
        void Create(T item);
        void Update(T item);
        void Delete(int Id);
    }
}
