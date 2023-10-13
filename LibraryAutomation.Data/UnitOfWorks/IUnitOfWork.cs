using LibraryAutomation.Core.Abstracts;
using LibraryAutomation.Data.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutomation.Data.UnitOfWorks
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        public IRepository<T> GetRepository<T>() where T : IBaseEntity;
        Task<int> SaveAsync();
        int Save();
    }
}
