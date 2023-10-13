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
    public class BookMap : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(new Book
            {
              
                Id = Guid.NewGuid(),
                Name = "Taht Oyunları (A Game of Thrones)",
                Page = 694,
                ReleaseDate = new DateTime(1996,01,01),
                UserId = new Guid("11223344-5566-7788-99AA-BBCCDDEEFF00"),
                ImageURL = "https://i.dr.com.tr/cache/600x600-0/originals/0000000368432-1.jpg",
                CreatedDate = DateTime.Now,
                AuthorId = new Guid("D0F5346E-0B4D-486A-8709-4158E92D36DF"),
                IsAvailable = true,
              
            },
            new Book
            {

                Id = Guid.NewGuid(),
                Name = "Kralların Çarpışması (A Clash of Kings)",
                Page = 761,
                ReleaseDate = new DateTime(1998, 01, 01),
                UserId = new Guid("11223344-5566-7788-99AA-BBCCDDEEFF00"),
                ImageURL = "https://upload.wikimedia.org/wikipedia/tr/c/c2/Krallarin-Carpismasi.jpg",
                CreatedDate = DateTime.Now,
                AuthorId = new Guid("D0F5346E-0B4D-486A-8709-4158E92D36DF"),
                IsAvailable = true,

            }, 
            new Book
            {

                Id = Guid.NewGuid(),
                Name = "Kılıçların Fırtınası (A Storm of Swords)",
                Page = 973,
                ReleaseDate = new DateTime(2000, 01, 01),
                UserId = new Guid("11223344-5566-7788-99AA-BBCCDDEEFF00"),
                ImageURL = "https://www.hobivizyon.com/UserFiles/Fotograflar/60205-9224-buyuk-jpg-9224-buyuk.jpg",
                CreatedDate = DateTime.Now,
                AuthorId = new Guid("D0F5346E-0B4D-486A-8709-4158E92D36DF"),
                IsAvailable = true,

            }, 
            new Book
            {

                Id = Guid.NewGuid(),
                Name = "Kralların Toprağı (A Feast for Crows)",
                Page = 753,
                ReleaseDate = new DateTime(2005, 01, 01),
                UserId = new Guid("11223344-5566-7788-99AA-BBCCDDEEFF00"),
                ImageURL = "https://m.media-amazon.com/images/I/91eJCheb4gL._AC_UF894,1000_QL80_.jpg",
                CreatedDate = DateTime.Now,
                AuthorId = new Guid("D0F5346E-0B4D-486A-8709-4158E92D36DF"),
                IsAvailable = true,

            }, 
            new Book
            {

                Id = Guid.NewGuid(),
                Name = "Ejderhaların Dansı (A Dance with Dragons)",
                Page = 1040,
                ReleaseDate = new DateTime(2011, 01, 01),
                UserId = new Guid("11223344-5566-7788-99AA-BBCCDDEEFF00"),
                ImageURL = "https://upload.wikimedia.org/wikipedia/tr/5/5d/Ejderhalarin-dansi.jpg",
                CreatedDate = DateTime.Now,
                AuthorId = new Guid("D0F5346E-0B4D-486A-8709-4158E92D36DF"),
                IsAvailable = true,

            }



            ); 
        }

       
    }
}
