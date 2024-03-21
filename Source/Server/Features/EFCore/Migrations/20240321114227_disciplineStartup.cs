using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Server.Features.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class disciplineStartup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Uri",
                table: "Startups",
                newName: "URI");

            migrationBuilder.AddColumn<string>(
                name: "Discipline",
                table: "Startups",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discipline",
                table: "Startups");

            migrationBuilder.RenameColumn(
                name: "URI",
                table: "Startups",
                newName: "Uri");
        }
    }
}
