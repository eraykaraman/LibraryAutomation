using LibraryAutomation.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutomation.Entity.Entities
{
    public class Author : BaseEntity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public List<Book> Books { get; set; }

    }
}
