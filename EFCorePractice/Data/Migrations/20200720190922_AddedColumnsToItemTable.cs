using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCorePractice.Data.Migrations
{
    public partial class AddedColumnsToItemTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImgUrl",
                schema: "Common",
                table: "Item",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                schema: "Common",
                table: "Item",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgUrl",
                schema: "Common",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Name",
                schema: "Common",
                table: "Item");
        }
    }
}
