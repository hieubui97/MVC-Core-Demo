using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_Core_Demo.Migrations
{
    public partial class decription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "decription",
                table: "Food",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "decription",
                table: "Food");
        }
    }
}
