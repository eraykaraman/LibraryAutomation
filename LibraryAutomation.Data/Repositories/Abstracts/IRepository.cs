using LibraryAutomation.Core.Abstracts;
using LibraryAutomation.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutomation.Data.Repositories.Abstracts
{
    public interface IRepository <T> where T : IBaseEntity
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(Guid id);
        Task<T> GetByFilter(Expression<Func<T, bool>> filter);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task RemoveAsync(Guid id);
        Task<List<Book>> GetAllBooksWithAuthorsAsync();
    }
}
