using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodingWiki_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class seedCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_BookAuthorMap_Fluent_Authors_Author_Id",
                table: "Fluent_BookAuthorMap");

            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_BookAuthorMap_Fluent_Books_IDBook",
                table: "Fluent_BookAuthorMap");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fluent_BookAuthorMap",
                table: "Fluent_BookAuthorMap");

            migrationBuilder.RenameTable(
                name: "Fluent_BookAuthorMap",
                newName: "Fluent_BookAuthorMaps");

            migrationBuilder.RenameIndex(
                name: "IX_Fluent_BookAuthorMap_IDBook",
                table: "Fluent_BookAuthorMaps",
                newName: "IX_Fluent_BookAuthorMaps_IDBook");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fluent_BookAuthorMaps",
                table: "Fluent_BookAuthorMaps",
                columns: new[] { "Author_Id", "IDBook" });

            migrationBuilder.AddForeignKey(
                name: "FK_Fluent_BookAuthorMaps_Fluent_Authors_Author_Id",
                table: "Fluent_BookAuthorMaps",
                column: "Author_Id",
                principalTable: "Fluent_Authors",
                principalColumn: "Author_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fluent_BookAuthorMaps_Fluent_Books_IDBook",
                table: "Fluent_BookAuthorMaps",
                column: "IDBook",
                principalTable: "Fluent_Books",
                principalColumn: "IDBook",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_BookAuthorMaps_Fluent_Authors_Author_Id",
                table: "Fluent_BookAuthorMaps");

            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_BookAuthorMaps_Fluent_Books_IDBook",
                table: "Fluent_BookAuthorMaps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fluent_BookAuthorMaps",
                table: "Fluent_BookAuthorMaps");

            migrationBuilder.RenameTable(
                name: "Fluent_BookAuthorMaps",
                newName: "Fluent_BookAuthorMap");

            migrationBuilder.RenameIndex(
                name: "IX_Fluent_BookAuthorMaps_IDBook",
                table: "Fluent_BookAuthorMap",
                newName: "IX_Fluent_BookAuthorMap_IDBook");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fluent_BookAuthorMap",
                table: "Fluent_BookAuthorMap",
                columns: new[] { "Author_Id", "IDBook" });

            migrationBuilder.AddForeignKey(
                name: "FK_Fluent_BookAuthorMap_Fluent_Authors_Author_Id",
                table: "Fluent_BookAuthorMap",
                column: "Author_Id",
                principalTable: "Fluent_Authors",
                principalColumn: "Author_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fluent_BookAuthorMap_Fluent_Books_IDBook",
                table: "Fluent_BookAuthorMap",
                column: "IDBook",
                principalTable: "Fluent_Books",
                principalColumn: "IDBook",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
