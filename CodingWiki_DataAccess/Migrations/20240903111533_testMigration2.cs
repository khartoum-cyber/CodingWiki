using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodingWiki_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class testMigration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "IDBook",
                keyValue: 2,
                column: "Publisher_Id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "IDBook",
                keyValue: 3,
                column: "Publisher_Id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "IDBook",
                keyValue: 4,
                column: "Publisher_Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "IDBook",
                keyValue: 5,
                column: "Publisher_Id",
                value: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "IDBook",
                keyValue: 2,
                column: "Publisher_Id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "IDBook",
                keyValue: 3,
                column: "Publisher_Id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "IDBook",
                keyValue: 4,
                column: "Publisher_Id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "IDBook",
                keyValue: 5,
                column: "Publisher_Id",
                value: 3);
        }
    }
}
