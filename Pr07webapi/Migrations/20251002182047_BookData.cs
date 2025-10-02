using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pr07webapi.Migrations
{
    /// <inheritdoc />
    public partial class BookData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Title", "Year" },
                values: new object[,]
                {
                    { 1, "Michael Bay", "Transformers", 2007 },
                    { 2, "F. Scott Fitzgerald", "The Great Gatsby", 1925 },
                    { 3, "Harper Lee", "To Kill a Mockingbird", 1960 },
                    { 4, "George Orwell", "1984", 1949 },
                    { 5, "J.K. Rowling", "Harry Potter and the Sorcerer's Stone", 1997 },
                    { 6, "J.R.R. Tolkien", "The Hobbit", 1937 },
                    { 7, "Jane Austen", "Pride and Prejudice", 1813 },
                    { 8, "J.D. Salinger", "The Catcher in the Rye", 1951 },
                    { 9, "J.R.R. Tolkien", "The Lord of the Rings", 1954 },
                    { 10, "George Orwell", "Animal Farm", 1945 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
