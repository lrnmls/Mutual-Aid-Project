using Microsoft.EntityFrameworkCore.Migrations;

namespace MutualAidRefactorEFCore.Data.Migrations
{
    public partial class Edit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accepted Request_Request_RequestId",
                schema: "Common",
                table: "Accepted Request");

            migrationBuilder.DropForeignKey(
                name: "FK_Accepted Request_User_UserId",
                schema: "Common",
                table: "Accepted Request");

            migrationBuilder.DropForeignKey(
                name: "FK_Request_User_UserId",
                schema: "Common",
                table: "Request");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                schema: "Common",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Request",
                schema: "Common",
                table: "Request");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Accepted Request",
                schema: "Common",
                table: "Accepted Request");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Common",
                table: "User");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Common",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Common",
                table: "Accepted Request");

            migrationBuilder.RenameTable(
                name: "User",
                schema: "Common",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "Request",
                schema: "Common",
                newName: "Requests");

            migrationBuilder.RenameTable(
                name: "Accepted Request",
                schema: "Common",
                newName: "AcceptedRequests");

            migrationBuilder.RenameIndex(
                name: "IX_Request_UserId",
                table: "Requests",
                newName: "IX_Requests_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Accepted Request_UserId",
                table: "AcceptedRequests",
                newName: "IX_AcceptedRequests_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Accepted Request_RequestId",
                table: "AcceptedRequests",
                newName: "IX_AcceptedRequests_RequestId");

            migrationBuilder.AlterColumn<string>(
                name: "Salt",
                table: "Users",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "County",
                table: "Users",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Requests",
                table: "Requests",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AcceptedRequests",
                table: "AcceptedRequests",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AcceptedRequests_Requests_RequestId",
                table: "AcceptedRequests",
                column: "RequestId",
                principalTable: "Requests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AcceptedRequests_Users_UserId",
                table: "AcceptedRequests",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Users_UserId",
                table: "Requests",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AcceptedRequests_Requests_RequestId",
                table: "AcceptedRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_AcceptedRequests_Users_UserId",
                table: "AcceptedRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Users_UserId",
                table: "Requests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Requests",
                table: "Requests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AcceptedRequests",
                table: "AcceptedRequests");

            migrationBuilder.EnsureSchema(
                name: "Common");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User",
                newSchema: "Common");

            migrationBuilder.RenameTable(
                name: "Requests",
                newName: "Request",
                newSchema: "Common");

            migrationBuilder.RenameTable(
                name: "AcceptedRequests",
                newName: "Accepted Request",
                newSchema: "Common");

            migrationBuilder.RenameIndex(
                name: "IX_Requests_UserId",
                schema: "Common",
                table: "Request",
                newName: "IX_Request_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AcceptedRequests_UserId",
                schema: "Common",
                table: "Accepted Request",
                newName: "IX_Accepted Request_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AcceptedRequests_RequestId",
                schema: "Common",
                table: "Accepted Request",
                newName: "IX_Accepted Request_RequestId");

            migrationBuilder.AlterColumn<string>(
                name: "Salt",
                schema: "Common",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                schema: "Common",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                schema: "Common",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                schema: "Common",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                schema: "Common",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                schema: "Common",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "County",
                schema: "Common",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Common",
                table: "User",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Common",
                table: "Request",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Common",
                table: "Accepted Request",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                schema: "Common",
                table: "User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Request",
                schema: "Common",
                table: "Request",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Accepted Request",
                schema: "Common",
                table: "Accepted Request",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Accepted Request_Request_RequestId",
                schema: "Common",
                table: "Accepted Request",
                column: "RequestId",
                principalSchema: "Common",
                principalTable: "Request",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Accepted Request_User_UserId",
                schema: "Common",
                table: "Accepted Request",
                column: "UserId",
                principalSchema: "Common",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Request_User_UserId",
                schema: "Common",
                table: "Request",
                column: "UserId",
                principalSchema: "Common",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
