using Microsoft.EntityFrameworkCore.Migrations;

namespace EFLayers.Models.Migrations
{
    public partial class Customer_UserId_UserName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Customers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Customers");
        }
    }
}
