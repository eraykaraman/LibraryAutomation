using LibraryAutomaiton.Service.Services.Abstracts;
using LibraryAutomation.Data.UnitOfWorks;
using LibraryAutomation.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutomaiton.Service.Services.Concretes
{
    public class RentService : IRentService
    {
        private readonly IUnitOfWork _unitOfWork;

        public RentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddAsync(Rent rent)
        {
           await _unitOfWork.GetRepository<Rent>().AddAsync(rent);
        }

        public async Task<List<Rent>> GetAllRentsAsync()
        {
            return await _unitOfWork.GetRepository<Rent>().GetAllAsync();
        }

        public async Task<Rent> GetByIdAsync(Guid id)
        {
            return await _unitOfWork.GetRepository<Rent>().GetByIdAsync(id);
        }

        public async Task RemoveAsync(Guid id)
        {
           await _unitOfWork.GetRepository<Rent>().RemoveAsync(id);
        }

       
    }
}
