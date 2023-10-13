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
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(new User
            {
                Id = new Guid("11223344-5566-7788-99AA-BBCCDDEEFF00"),
                Name = "Library",
                LastName = "Account",
                CreatedDate = DateTime.Now,
                Email = "library@mail.com",
                Phone = "+1234567899",
                
            });
        }
    }
}
