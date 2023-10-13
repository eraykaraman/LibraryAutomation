using LibraryAutomation.Core.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutomation.Core.Entities
{
    public abstract class BaseEntity : IBaseEntity
    {
        public virtual Guid Id { get; set; } = Guid.NewGuid();
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
