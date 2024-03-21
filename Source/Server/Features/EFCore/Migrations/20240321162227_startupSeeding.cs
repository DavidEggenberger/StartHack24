using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Server.Features.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class startupSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FounderEmail",
                table: "Startups",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Startups",
                columns: new[] { "Id", "Batch", "Description", "Discipline", "FounderEmail", "Location", "Name", "URI" },
                values: new object[] { new Guid("f6d0f0a0-c3bb-4cd6-97a9-7bb7ecae0eae"), "2024", "SaaS for cleaning companies", "SaaS", "test.founder@fellowship.com", "Brazil", "Cleantech", "www.cleantech.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Startups",
                keyColumn: "Id",
                keyValue: new Guid("f6d0f0a0-c3bb-4cd6-97a9-7bb7ecae0eae"));

            migrationBuilder.DropColumn(
                name: "FounderEmail",
                table: "Startups");
        }
    }
}
