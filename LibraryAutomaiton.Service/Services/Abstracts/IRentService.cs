using LibraryAutomation.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutomaiton.Service.Services.Abstracts
{
    public interface IRentService
    {
        Task<List<Rent>> GetAllRentsAsync();
        Task AddAsync(Rent rent);
        Task RemoveAsync(Guid id);
        Task<Rent> GetByIdAsync(Guid id);
    }
}
