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
    public class AuthorService : IAuthorService
    {
        private readonly IUnitOfWork _unitOfWork;

        public AuthorService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddAsync(Author author)
        {
           await _unitOfWork.GetRepository<Author>().AddAsync(author);
        }

        public async Task<List<Author>> GetAllAuthorsAsync()
        {
            return await _unitOfWork.GetRepository<Author>().GetAllAsync();
        }
    }
}
