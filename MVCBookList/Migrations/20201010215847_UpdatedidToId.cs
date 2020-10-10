using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCBookList.Migrations
{
    public partial class UpdatedidToId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "Book",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Book",
                newName: "id");
        }
    }
}
