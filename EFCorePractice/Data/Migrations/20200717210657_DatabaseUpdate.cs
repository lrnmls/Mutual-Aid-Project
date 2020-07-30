using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCorePractice.Data.Migrations
{
    public partial class DatabaseUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                schema: "Common",
                table: "Order");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                schema: "Common",
                table: "User",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                schema: "Common",
                table: "User",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "TotalPrice",
                schema: "Common",
                table: "Order",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "Item",
                schema: "Common",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    CreateDateTime = table.Column<DateTime>(nullable: false),
                    UpdateDateTime = table.Column<DateTime>(nullable: true),
                    OrderId = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Item_Order_OrderId",
                        column: x => x.OrderId,
                        principalSchema: "Common",
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Item_OrderId",
                schema: "Common",
                table: "Item",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Item",
                schema: "Common");

            migrationBuilder.DropColumn(
                name: "Email",
                schema: "Common",
                table: "User");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                schema: "Common",
                table: "User");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                schema: "Common",
                table: "Order");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                schema: "Common",
                table: "Order",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
