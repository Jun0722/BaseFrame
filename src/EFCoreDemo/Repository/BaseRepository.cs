using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EFCoreDemo.Data;
using EFCoreDemo.IRepository;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDemo.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private NoteContext _context;
        public BaseRepository(NoteContext context)
        {
            _context = context;
        }
        async Task Save() => await _context.SaveChangesAsync();

        public async Task AddAsync(T entity)
        {
            await _context.AddAsync(entity);
            await Save();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<List<T>> ListAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await Save();
        }
    }
}
