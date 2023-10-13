using LibraryAutomation.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutomation.Data.Mappings
{
    public class AuthorMap : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasData(new Author
            {
                Id = new Guid("D0F5346E-0B4D-486A-8709-4158E92D36DF"),
                Name = "George R.R.",
                LastName = "Martin",
                CreatedDate = DateTime.Now,
               

            });
        }
    }
}
