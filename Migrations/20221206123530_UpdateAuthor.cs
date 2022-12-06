using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Torok_Erika_Lab2.Migrations
{
    public partial class UpdateAuthor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AuthorsID",
                table: "Book",
                newName: "AuthorID");

      
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AuthorID",
                table: "Book",
                newName: "AuthorsID");
        }
    }
}
