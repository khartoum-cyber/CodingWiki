using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodingWiki_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class seedDbWithBooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "IDBook",
                keyValue: 1,
                column: "Title",
                value: "Spider without Duty1");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "IDBook",
                keyValue: 2,
                column: "Title",
                value: "Fortune of time1");

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
                column: "Title",
                value: "Cookie Jar1");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "IDBook",
                keyValue: 5,
                column: "Title",
                value: "Cloudy Forest1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "IDBook",
                keyValue: 1,
                column: "Title",
                value: "Spider without Duty");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "IDBook",
                keyValue: 2,
                column: "Title",
                value: "Fortune of time");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "IDBook",
                keyValue: 3,
                column: "Title",
                value: "Fake Sunday");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "IDBook",
                keyValue: 4,
                column: "Title",
                value: "Cookie Jar");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "IDBook",
                keyValue: 5,
                column: "Title",
                value: "Cloudy Forest");
        }
    }
}
