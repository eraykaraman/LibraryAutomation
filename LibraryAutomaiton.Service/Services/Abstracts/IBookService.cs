using LibraryAutomation.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutomaiton.Service.Services.Abstracts
{
    public interface IBookService
    {
        Task<List<Book>> GetAllBooksAsync();
        Task<List<Book>> GetAllBooksWithAuthorsAsync();
        Task <Book> GetByIdAsync(Guid id);
        Task AddAsync(Book book);
        Task<int> SaveAsync();
    }
}
