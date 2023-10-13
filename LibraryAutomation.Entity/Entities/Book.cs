using LibraryAutomation.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutomation.Entity.Entities
{
    public class Book : BaseEntity
    {
        public string Name  { get; set; }
        public  int Page { get; set; }
        public  DateTime ReleaseDate { get; set; }
        public bool IsAvailable { get; set; }
        public string ImageURL { get; set; }
        public  Guid AuthorId { get; set; }
        public Author Author { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }

    }
}
