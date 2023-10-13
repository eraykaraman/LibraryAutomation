using LibraryAutomation.Core.Abstracts;
using LibraryAutomation.Data.Context;
using LibraryAutomation.Data.Repositories.Abstracts;
using LibraryAutomation.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutomation.Data.Repositories.Concretes
{
    public class Repository<T> : IRepository <T> where T : IBaseEntity
    {
        private readonly LibraryDbContext _libraryDbContext;

        public Repository(LibraryDbContext libraryDbContext)
        {
            _libraryDbContext = libraryDbContext;
        }


        public async Task AddAsync(T entity)
        {
            await _libraryDbContext.Set<T>().AddAsync(entity);
            await _libraryDbContext.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _libraryDbContext.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T> GetByFilter(Expression<Func<T, bool>> filter)
        {
            return await _libraryDbContext.Set<T>().AsNoTracking().SingleOrDefaultAsync(filter);
            
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            return await _libraryDbContext.Set<T>().FindAsync(id);
        }


        public async Task UpdateAsync(T entity)
        {
            _libraryDbContext.Set<T>().Update(entity);
            await _libraryDbContext.SaveChangesAsync();

        }

        public async Task RemoveAsync(Guid id)
        {
            var data = await _libraryDbContext.Set<T>().FindAsync(id);
             _libraryDbContext.Remove(data);
            await _libraryDbContext.SaveChangesAsync();
        }

        public async Task<List<Book>> GetAllBooksWithAuthorsAsync()
        {
            return await _libraryDbContext.Set<Book>()
                .Include(b => b.Author)
                .AsNoTracking()
                .OrderBy(b => b.Name)
                .ToListAsync();
        }




    }
}
