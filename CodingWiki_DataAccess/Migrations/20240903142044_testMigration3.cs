using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodingWiki_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class testMigration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IDBook",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IDBook",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "IDBook",
                keyValue: 3,
                column: "Title",
                value: "Fake Sunday 999");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "IDBook",
                keyValue: 4,
                columns: new[] { "Publisher_Id", "Title" },
                values: new object[] { 2, "Cookie Jar1 999" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "IDBook",
                keyValue: 5,
                columns: new[] { "Publisher_Id", "Title" },
                values: new object[] { 1, "Cloudy Forest 999" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "IDBook",
                keyValue: 3,
                column: "Title",
                value: "Fake Sunday1");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "IDBook",
                keyValue: 4,
                columns: new[] { "Publisher_Id", "Title" },
                values: new object[] { 0, "Cookie Jar1" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "IDBook",
                keyValue: 5,
                columns: new[] { "Publisher_Id", "Title" },
                values: new object[] { 0, "Cloudy Forest1" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "IDBook", "ISBN", "Price", "Publisher_Id", "Title" },
                values: new object[,]
                {
                    { 1, "123B12", 10.99m, 1, "Spider without Duty1" },
                    { 2, "12123B12", 11.99m, 2, "Fortune of time1" }
                });
        }
    }
}
