using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Server.Features.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class startUpContentUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Founders",
                keyColumn: "Id",
                keyValue: new Guid("b2054598-3533-45d7-86a4-05e69560c015"));

            migrationBuilder.DeleteData(
                table: "Startups",
                keyColumn: "Id",
                keyValue: new Guid("1549bff0-1f1b-4d05-9266-50f266ff6075"));

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "StartupContents",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "StartupContents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Startup",
                table: "StartupContents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "StartupContents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Founders",
                columns: new[] { "Id", "Email", "MobileEnabled", "MobileNumber" },
                values: new object[] { new Guid("8584baa2-7afd-4008-aa92-b923cbd6c451"), "test.founder@fellowship.com", false, "1234567" });

            migrationBuilder.InsertData(
                table: "Startups",
                columns: new[] { "Id", "Batch", "Description", "Discipline", "FounderEmail", "Location", "Name", "URI" },
                values: new object[] { new Guid("1bbd959b-659f-49f9-8acc-b37bba1b8b65"), "2024", "SaaS for cleaning companies", "SaaS", "test.founder@fellowship.com", "Brazil", "Cleantech", "www.cleantech.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Founders",
                keyColumn: "Id",
                keyValue: new Guid("8584baa2-7afd-4008-aa92-b923cbd6c451"));

            migrationBuilder.DeleteData(
                table: "Startups",
                keyColumn: "Id",
                keyValue: new Guid("1bbd959b-659f-49f9-8acc-b37bba1b8b65"));

            migrationBuilder.DropColumn(
                name: "Date",
                table: "StartupContents");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "StartupContents");

            migrationBuilder.DropColumn(
                name: "Startup",
                table: "StartupContents");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "StartupContents");

            migrationBuilder.InsertData(
                table: "Founders",
                columns: new[] { "Id", "Email", "MobileEnabled", "MobileNumber" },
                values: new object[] { new Guid("b2054598-3533-45d7-86a4-05e69560c015"), "test.founder@fellowship.com", false, "1234567" });

            migrationBuilder.InsertData(
                table: "Startups",
                columns: new[] { "Id", "Batch", "Description", "Discipline", "FounderEmail", "Location", "Name", "URI" },
                values: new object[] { new Guid("1549bff0-1f1b-4d05-9266-50f266ff6075"), "2024", "SaaS for cleaning companies", "SaaS", "test.founder@fellowship.com", "Brazil", "Cleantech", "www.cleantech.com" });
        }
    }
}
