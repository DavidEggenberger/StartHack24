using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Server.Features.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class founderEmail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Startups",
                keyColumn: "Id",
                keyValue: new Guid("f6d0f0a0-c3bb-4cd6-97a9-7bb7ecae0eae"));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Founders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MobileNumber",
                table: "Founders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "StartupContents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Domain = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StartupContents", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Founders",
                columns: new[] { "Id", "Email", "MobileNumber" },
                values: new object[] { new Guid("729a4768-fc7e-422b-8221-c3eef3628df5"), "test.founder@fellowship.com", "1234567" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StartupContents");

            migrationBuilder.DeleteData(
                table: "Founders",
                keyColumn: "Id",
                keyValue: new Guid("729a4768-fc7e-422b-8221-c3eef3628df5"));

            migrationBuilder.DeleteData(
                table: "Startups",
                keyColumn: "Id",
                keyValue: new Guid("4f66a9c1-fc2b-476b-9109-d223b5e16f74"));

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Founders");

            migrationBuilder.DropColumn(
                name: "MobileNumber",
                table: "Founders");
        }
    }
}
