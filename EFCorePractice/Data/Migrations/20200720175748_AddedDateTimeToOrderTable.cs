using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCorePractice.Data.Migrations
{
    public partial class AddedDateTimeToOrderTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateTime",
                schema: "Common",
                table: "Order",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                schema: "Common",
                table: "Item",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Common",
                table: "Item",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateTime",
                schema: "Common",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Description",
                schema: "Common",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Common",
                table: "Item");
        }
    }
}
