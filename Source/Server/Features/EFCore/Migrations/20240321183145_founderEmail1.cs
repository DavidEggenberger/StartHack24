using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Server.Features.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class founderEmail1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Founders",
                keyColumn: "Id",
                keyValue: new Guid("729a4768-fc7e-422b-8221-c3eef3628df5"));

            migrationBuilder.DeleteData(
                table: "Startups",
                keyColumn: "Id",
                keyValue: new Guid("4f66a9c1-fc2b-476b-9109-d223b5e16f74"));

            migrationBuilder.InsertData(
                table: "Founders",
                columns: new[] { "Id", "Email", "MobileNumber" },
                values: new object[] { new Guid("8822364a-4721-4b81-baf0-0ad75aab7034"), "test.founder@fellowship.com", "1234567" });

            migrationBuilder.InsertData(
                table: "Startups",
                columns: new[] { "Id", "Batch", "Description", "Discipline", "FounderEmail", "Location", "Name", "URI" },
                values: new object[] { new Guid("3db246c3-a057-4d27-b967-b78dda2addd5"), "2024", "SaaS for cleaning companies", "SaaS", "test.founder@fellowship.com", "Brazil", "Cleantech", "www.cleantech.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Founders",
                keyColumn: "Id",
                keyValue: new Guid("8822364a-4721-4b81-baf0-0ad75aab7034"));

            migrationBuilder.DeleteData(
                table: "Startups",
                keyColumn: "Id",
                keyValue: new Guid("3db246c3-a057-4d27-b967-b78dda2addd5"));

            migrationBuilder.InsertData(
                table: "Founders",
                columns: new[] { "Id", "Email", "MobileNumber" },
                values: new object[] { new Guid("729a4768-fc7e-422b-8221-c3eef3628df5"), "test.founder@fellowship.com", "1234567" });

            migrationBuilder.InsertData(
                table: "Startups",
                columns: new[] { "Id", "Batch", "Description", "Discipline", "FounderEmail", "Location", "Name", "URI" },
                values: new object[] { new Guid("4f66a9c1-fc2b-476b-9109-d223b5e16f74"), "2024", "SaaS for cleaning companies", "SaaS", "test.founder@fellowship.com", "Brazil", "Cleantech", "www.cleantech.com" });
        }
    }
}
