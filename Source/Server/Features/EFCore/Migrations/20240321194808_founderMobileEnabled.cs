using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Server.Features.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class founderMobileEnabled : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Founders",
                keyColumn: "Id",
                keyValue: new Guid("8822364a-4721-4b81-baf0-0ad75aab7034"));

            migrationBuilder.DeleteData(
                table: "Startups",
                keyColumn: "Id",
                keyValue: new Guid("3db246c3-a057-4d27-b967-b78dda2addd5"));

            migrationBuilder.AddColumn<bool>(
                name: "MobileEnabled",
                table: "Founders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Founders",
                columns: new[] { "Id", "Email", "MobileEnabled", "MobileNumber" },
                values: new object[] { new Guid("b2054598-3533-45d7-86a4-05e69560c015"), "test.founder@fellowship.com", false, "1234567" });

            migrationBuilder.InsertData(
                table: "Startups",
                columns: new[] { "Id", "Batch", "Description", "Discipline", "FounderEmail", "Location", "Name", "URI" },
                values: new object[] { new Guid("1549bff0-1f1b-4d05-9266-50f266ff6075"), "2024", "SaaS for cleaning companies", "SaaS", "test.founder@fellowship.com", "Brazil", "Cleantech", "www.cleantech.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Founders",
                keyColumn: "Id",
                keyValue: new Guid("b2054598-3533-45d7-86a4-05e69560c015"));

            migrationBuilder.DeleteData(
                table: "Startups",
                keyColumn: "Id",
                keyValue: new Guid("1549bff0-1f1b-4d05-9266-50f266ff6075"));

            migrationBuilder.DropColumn(
                name: "MobileEnabled",
                table: "Founders");

            migrationBuilder.InsertData(
                table: "Founders",
                columns: new[] { "Id", "Email", "MobileNumber" },
                values: new object[] { new Guid("8822364a-4721-4b81-baf0-0ad75aab7034"), "test.founder@fellowship.com", "1234567" });

            migrationBuilder.InsertData(
                table: "Startups",
                columns: new[] { "Id", "Batch", "Description", "Discipline", "FounderEmail", "Location", "Name", "URI" },
                values: new object[] { new Guid("3db246c3-a057-4d27-b967-b78dda2addd5"), "2024", "SaaS for cleaning companies", "SaaS", "test.founder@fellowship.com", "Brazil", "Cleantech", "www.cleantech.com" });
        }
    }
}
