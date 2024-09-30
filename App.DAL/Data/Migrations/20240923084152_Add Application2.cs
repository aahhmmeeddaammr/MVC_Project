using Microsoft.EntityFrameworkCore.Migrations;

namespace App.DAL.Data.Migrations
{
    public partial class AddApplication2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Fname",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lname",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fname",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Lname",
                table: "Users");
        }
    }
}
