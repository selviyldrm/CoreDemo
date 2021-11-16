using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_repeatpasswordsil : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WriterPasswordRepeat",
                table: "Writers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WriterPasswordRepeat",
                table: "Writers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
