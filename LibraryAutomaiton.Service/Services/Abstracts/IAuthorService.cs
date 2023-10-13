using LibraryAutomation.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutomaiton.Service.Services.Abstracts
{
    public interface IAuthorService
    {
        Task <List<Author>> GetAllAuthorsAsync();
        Task AddAsync(Author author);
    }
}
