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
    public class BookService : IBookService
    {
        private readonly IUnitOfWork _unitOfWork;

        public BookService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<Book>> GetAllBooksAsync()
        {
           return await _unitOfWork.GetRepository<Book>().GetAllAsync();
        }

        public async Task<List<Book>> GetAllBooksWithAuthorsAsync()
        {
            return await _unitOfWork.GetRepository<Book>().GetAllBooksWithAuthorsAsync();
        }

        public async Task AddAsync(Book book)
        {
             await _unitOfWork.GetRepository<Book>().AddAsync(book);
        }

        public async Task<Book> GetByIdAsync(Guid id)
        {
            return await _unitOfWork.GetRepository<Book>().GetByIdAsync(id);
        }

        public async Task<int> SaveAsync()
        {
            return await _unitOfWork.SaveAsync();
        }
    }
}
