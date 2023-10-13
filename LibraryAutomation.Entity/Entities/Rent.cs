using LibraryAutomation.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutomation.Entity.Entities
{
    public class Rent: BaseEntity
    {
        public Guid BookId { get; set; }
        public string RenterName { get; set; } 
        public DateTime DueDate { get; set; } 

    }
}
