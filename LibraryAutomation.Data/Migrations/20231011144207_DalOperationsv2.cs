using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryAutomation.Data.Migrations
{
    public partial class DalOperationsv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "CreatedDate", "LastName", "Name" },
                values: new object[] { new Guid("d0f5346e-0b4d-486a-8709-4158e92d36df"), new DateTime(2023, 10, 11, 17, 42, 7, 523, DateTimeKind.Local).AddTicks(6561), "Martin", "George R.R." });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "Email", "LastName", "Name", "Phone" },
                values: new object[] { new Guid("11223344-5566-7788-99aa-bbccddeeff00"), new DateTime(2023, 10, 11, 17, 42, 7, 523, DateTimeKind.Local).AddTicks(7044), "library@mail.com", "Account", "Library", "+1234567899" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "CreatedDate", "ImageURL", "IsAvailable", "Name", "Page", "ReleaseDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("1af19fc5-fc5d-40e7-a166-c81e86d96abf"), new Guid("d0f5346e-0b4d-486a-8709-4158e92d36df"), new DateTime(2023, 10, 11, 17, 42, 7, 523, DateTimeKind.Local).AddTicks(6880), "https://upload.wikimedia.org/wikipedia/tr/5/5d/Ejderhalarin-dansi.jpg", true, "Ejderhaların Dansı (A Dance with Dragons)", 1040, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("11223344-5566-7788-99aa-bbccddeeff00") },
                    { new Guid("2bb9898a-55e2-4c7a-8877-f49f157ed831"), new Guid("d0f5346e-0b4d-486a-8709-4158e92d36df"), new DateTime(2023, 10, 11, 17, 42, 7, 523, DateTimeKind.Local).AddTicks(6852), "https://i.dr.com.tr/cache/600x600-0/originals/0000000368432-1.jpg", true, "Taht Oyunları (A Game of Thrones)", 694, new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("11223344-5566-7788-99aa-bbccddeeff00") },
                    { new Guid("666df7dc-72e2-40a4-807b-c3d51fae0ccd"), new Guid("d0f5346e-0b4d-486a-8709-4158e92d36df"), new DateTime(2023, 10, 11, 17, 42, 7, 523, DateTimeKind.Local).AddTicks(6871), "https://m.media-amazon.com/images/I/91eJCheb4gL._AC_UF894,1000_QL80_.jpg", true, "Kralların Toprağı (A Feast for Crows)", 753, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("11223344-5566-7788-99aa-bbccddeeff00") },
                    { new Guid("c480a849-f2e6-4fee-aa5c-5f056086181c"), new Guid("d0f5346e-0b4d-486a-8709-4158e92d36df"), new DateTime(2023, 10, 11, 17, 42, 7, 523, DateTimeKind.Local).AddTicks(6865), "https://www.hobivizyon.com/UserFiles/Fotograflar/60205-9224-buyuk-jpg-9224-buyuk.jpg", true, "Kılıçların Fırtınası (A Storm of Swords)", 973, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("11223344-5566-7788-99aa-bbccddeeff00") },
                    { new Guid("ed30955d-8119-4f8e-80f4-a6235e908cfa"), new Guid("d0f5346e-0b4d-486a-8709-4158e92d36df"), new DateTime(2023, 10, 11, 17, 42, 7, 523, DateTimeKind.Local).AddTicks(6859), "https://upload.wikimedia.org/wikipedia/tr/c/c2/Krallarin-Carpismasi.jpg", true, "Kralların Çarpışması (A Clash of Kings)", 761, new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("11223344-5566-7788-99aa-bbccddeeff00") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1af19fc5-fc5d-40e7-a166-c81e86d96abf"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2bb9898a-55e2-4c7a-8877-f49f157ed831"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("666df7dc-72e2-40a4-807b-c3d51fae0ccd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c480a849-f2e6-4fee-aa5c-5f056086181c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ed30955d-8119-4f8e-80f4-a6235e908cfa"));

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
