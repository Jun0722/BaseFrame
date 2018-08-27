using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EFCoreDemo.IRepository
{
    public interface IBaseRepository<T> where T:class
    {
        Task<T> GetByIdAsync(int id);
        Task<List<T>> ListAsync();
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);

    }
}
