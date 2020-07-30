using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MutualAidRefactorEFCore.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Common");

            migrationBuilder.CreateTable(
                name: "User",
                schema: "Common",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Salt = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false),
                    County = table.Column<string>(nullable: false),
                    isAdmin = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Request",
                schema: "Common",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    IsAccepted = table.Column<bool>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    ToiletPaper = table.Column<string>(nullable: true),
                    PaperTowels = table.Column<string>(nullable: true),
                    HandSoap = table.Column<string>(nullable: true),
                    Shampoo = table.Column<string>(nullable: true),
                    Conditioner = table.Column<string>(nullable: true),
                    Toothpaste = table.Column<string>(nullable: true),
                    Disinfectant = table.Column<string>(nullable: true),
                    Dairy = table.Column<string>(nullable: true),
                    Bread = table.Column<string>(nullable: true),
                    Produce = table.Column<string>(nullable: true),
                    CannedFood = table.Column<string>(nullable: true),
                    Meat = table.Column<string>(nullable: true),
                    Seafood = table.Column<string>(nullable: true),
                    Cereal = table.Column<string>(nullable: true),
                    Pantry = table.Column<string>(nullable: true),
                    Allergens = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Request", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Request_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "Common",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Accepted Request",
                schema: "Common",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    RequestId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accepted Request", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accepted Request_Request_RequestId",
                        column: x => x.RequestId,
                        principalSchema: "Common",
                        principalTable: "Request",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Accepted Request_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "Common",
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accepted Request_RequestId",
                schema: "Common",
                table: "Accepted Request",
                column: "RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_Accepted Request_UserId",
                schema: "Common",
                table: "Accepted Request",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Request_UserId",
                schema: "Common",
                table: "Request",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accepted Request",
                schema: "Common");

            migrationBuilder.DropTable(
                name: "Request",
                schema: "Common");

            migrationBuilder.DropTable(
                name: "User",
                schema: "Common");
        }
    }
}
