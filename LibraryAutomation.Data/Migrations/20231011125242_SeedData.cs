using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryAutomation.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "CreatedDate", "LastName", "Name" },
                values: new object[] { new Guid("d0f5346e-0b4d-486a-8709-4158e92d36df"), new DateTime(2023, 10, 11, 15, 52, 42, 284, DateTimeKind.Local).AddTicks(7249), "Martin", "George R.R." });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "Email", "LastName", "Name", "Phone" },
                values: new object[] { new Guid("11223344-5566-7788-99aa-bbccddeeff00"), new DateTime(2023, 10, 11, 15, 52, 42, 284, DateTimeKind.Local).AddTicks(7893), "library@mail.com", "Account", "Library", "+1234567899" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "CreatedDate", "ImageURL", "IsAvailable", "Name", "Page", "ReleaseDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("0ed82b98-0840-40aa-bbb0-1c70752411bd"), new Guid("d0f5346e-0b4d-486a-8709-4158e92d36df"), new DateTime(2023, 10, 11, 15, 52, 42, 284, DateTimeKind.Local).AddTicks(7502), "https://upload.wikimedia.org/wikipedia/tr/c/c2/Krallarin-Carpismasi.jpg", true, "Kralların Çarpışması (A Clash of Kings)", 761, new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("11223344-5566-7788-99aa-bbccddeeff00") },
                    { new Guid("735dd6d8-ff3f-44f5-a159-cd6d7aa3a190"), new Guid("d0f5346e-0b4d-486a-8709-4158e92d36df"), new DateTime(2023, 10, 11, 15, 52, 42, 284, DateTimeKind.Local).AddTicks(7507), "https://www.hobivizyon.com/UserFiles/Fotograflar/60205-9224-buyuk-jpg-9224-buyuk.jpg", true, "Kılıçların Fırtınası (A Storm of Swords)", 973, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("11223344-5566-7788-99aa-bbccddeeff00") },
                    { new Guid("b3a0cfaa-c81e-4ff4-9158-27af3d3743e8"), new Guid("d0f5346e-0b4d-486a-8709-4158e92d36df"), new DateTime(2023, 10, 11, 15, 52, 42, 284, DateTimeKind.Local).AddTicks(7534), "https://upload.wikimedia.org/wikipedia/tr/5/5d/Ejderhalarin-dansi.jpg", true, "Ejderhaların Dansı (A Dance with Dragons)", 1040, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("11223344-5566-7788-99aa-bbccddeeff00") },
                    { new Guid("c5f0be9c-c43b-4f5a-9a95-706b1cd7e5a9"), new Guid("d0f5346e-0b4d-486a-8709-4158e92d36df"), new DateTime(2023, 10, 11, 15, 52, 42, 284, DateTimeKind.Local).AddTicks(7494), "https://i.dr.com.tr/cache/600x600-0/originals/0000000368432-1.jpg", true, "Taht Oyunları (A Game of Thrones)", 694, new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("11223344-5566-7788-99aa-bbccddeeff00") },
                    { new Guid("e92090a9-206f-4b1b-9c65-50fd453886fc"), new Guid("d0f5346e-0b4d-486a-8709-4158e92d36df"), new DateTime(2023, 10, 11, 15, 52, 42, 284, DateTimeKind.Local).AddTicks(7528), "https://m.media-amazon.com/images/I/91eJCheb4gL._AC_UF894,1000_QL80_.jpg", true, "Kralların Toprağı (A Feast for Crows)", 753, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("11223344-5566-7788-99aa-bbccddeeff00") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0ed82b98-0840-40aa-bbb0-1c70752411bd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("735dd6d8-ff3f-44f5-a159-cd6d7aa3a190"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b3a0cfaa-c81e-4ff4-9158-27af3d3743e8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c5f0be9c-c43b-4f5a-9a95-706b1cd7e5a9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e92090a9-206f-4b1b-9c65-50fd453886fc"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("d0f5346e-0b4d-486a-8709-4158e92d36df"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11223344-5566-7788-99aa-bbccddeeff00"));
        }
    }
}
