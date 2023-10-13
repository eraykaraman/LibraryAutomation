using LibraryAutomation.Core.Abstracts;
using LibraryAutomation.Data.Context;
using LibraryAutomation.Data.Repositories.Abstracts;
using LibraryAutomation.Data.Repositories.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutomation.Data.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LibraryDbContext _libraryDbContext;

        public UnitOfWork(LibraryDbContext libraryDbContext)
        {
            _libraryDbContext = libraryDbContext;
        }

        public async ValueTask DisposeAsync()
        {
            await _libraryDbContext.DisposeAsync(); 
        }

        public IRepository<T> GetRepository<T>() where T : IBaseEntity
        {
            return new Repository<T>(_libraryDbContext);
        }

        public int Save()
        {
            return _libraryDbContext.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await _libraryDbContext.SaveChangesAsync();
        }
    }
}
