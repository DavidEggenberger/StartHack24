using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Features.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class startupContentId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Founders",
                keyColumn: "Id",
                keyValue: new Guid("8584baa2-7afd-4008-aa92-b923cbd6c451"));

            migrationBuilder.DeleteData(
                table: "Startups",
                keyColumn: "Id",
                keyValue: new Guid("1bbd959b-659f-49f9-8acc-b37bba1b8b65"));

            migrationBuilder.AddColumn<Guid>(
                name: "StartupId",
                table: "StartupContents",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Founders",
                columns: new[] { "Id", "Email", "MobileEnabled", "MobileNumber" },
                values: new object[,]
                {
                    { new Guid("3b95a5bb-d135-4dc9-9d48-76cde8876b75"), "fibers@email.com", false, "45454556" },
                    { new Guid("5a91f566-37db-4052-b09c-7e569555706a"), "aiRestaurant@email.com", false, "45454556" },
                    { new Guid("7c999d15-0ced-4f11-87fb-dbd2e9620e49"), "test.founder@fellowship.com", false, "45454556" },
                    { new Guid("c2584b35-3c07-45f3-aef8-dd885039a837"), "medtech@email.com", false, "45454556" },
                    { new Guid("da4c0289-4aca-4c7a-a204-ff46d5e11594"), "aiFarmers@email.com", false, "45454556" },
                    { new Guid("dc979906-992e-4412-abb8-cc542ab3a59f"), "legaltech@email.com", false, "45454556" }
                });

            migrationBuilder.InsertData(
                table: "StartupContents",
                columns: new[] { "Id", "Date", "Description", "Domain", "Startup", "StartupId", "Title", "Type" },
                values: new object[,]
                {
                    { new Guid("022d4dd2-9066-4474-bbf1-05dcbddcb455"), new DateTime(2024, 3, 13, 3, 38, 0, 351, DateTimeKind.Local).AddTicks(6798), "we are saving emissons by working remote", null, "Cleantech", new Guid("e2804dfe-56fb-47a5-b57a-0d812ca6d465"), "working remote saves emissions", 2 },
                    { new Guid("1af15345-0468-462c-b134-1d6231e83edb"), new DateTime(2024, 3, 19, 3, 38, 0, 351, DateTimeKind.Local).AddTicks(6703), "We could reduce our ecological footprint", null, "Cleantech", new Guid("e2804dfe-56fb-47a5-b57a-0d812ca6d465"), "Succesfully reduced carbon footprint", 2 },
                    { new Guid("1cdd65d0-3ad9-4a29-a865-bff1a945cb2f"), new DateTime(2023, 12, 24, 3, 38, 0, 351, DateTimeKind.Local).AddTicks(6548), "From now on, we visit all our customers by train", null, "Cleantech", new Guid("327ab63f-e42c-4650-98e1-b4af7a8e9bed"), "Taking the train for business tripps", 2 },
                    { new Guid("2bd291d4-5e85-47b9-b542-325f25f4bb7f"), new DateTime(2024, 1, 12, 3, 38, 0, 351, DateTimeKind.Local).AddTicks(6609), "We have 3 new openings in the finance department", null, "MedDents", new Guid("e2804dfe-56fb-47a5-b57a-0d812ca6d465"), "Bigger finance team", 1 },
                    { new Guid("40e1f91a-f105-4bf2-bcdb-fea11e640c2f"), new DateTime(2024, 1, 15, 3, 38, 0, 351, DateTimeKind.Local).AddTicks(7008), "We are officially licensed for use in courts", null, "BiteAI", new Guid("00000000-0000-0000-0000-000000000000"), "Licensed for use in courts", 3 },
                    { new Guid("4b44b605-0628-48d3-be41-9bf766be14ad"), new DateTime(2024, 3, 15, 3, 38, 0, 351, DateTimeKind.Local).AddTicks(6865), "We raised our 2 million Series A round", null, "AI Farmers", new Guid("00000000-0000-0000-0000-000000000000"), "Big series A", 0 },
                    { new Guid("566cb036-7a28-4632-a26f-6327e8885842"), new DateTime(2024, 3, 21, 3, 38, 0, 351, DateTimeKind.Local).AddTicks(6884), "Our engineering team looks for promising colleagues.", null, "AI Farmers", new Guid("00000000-0000-0000-0000-000000000000"), "Open jobs in engineering", 1 },
                    { new Guid("573a3ecd-fcd5-471d-80a2-99b48c933c6a"), new DateTime(2024, 2, 22, 3, 38, 0, 351, DateTimeKind.Local).AddTicks(6777), "we are saving emissons by working remote", null, "Cleantech", new Guid("e2804dfe-56fb-47a5-b57a-0d812ca6d465"), "working remote saves emissions", 2 },
                    { new Guid("72c50517-3ba2-4212-9ad6-2002139e3881"), new DateTime(2022, 11, 16, 3, 38, 0, 351, DateTimeKind.Local).AddTicks(6740), "Successfully mitigated a hacker attack", null, "Cleantech", new Guid("e2804dfe-56fb-47a5-b57a-0d812ca6d465"), "Prevented a hacker attack", 3 },
                    { new Guid("883408e2-f703-405f-91c6-78b3b20f755b"), new DateTime(2023, 12, 3, 3, 38, 0, 351, DateTimeKind.Local).AddTicks(6682), "We have a new partner manager", null, "MedDents", new Guid("e2804dfe-56fb-47a5-b57a-0d812ca6d465"), "Welcoming new faces", 1 },
                    { new Guid("ac511d92-4cc3-46fb-b08e-32236f4b76a9"), new DateTime(2024, 2, 29, 3, 38, 0, 351, DateTimeKind.Local).AddTicks(6956), "With our AI we can help in saving emissions", null, "BiteAI", new Guid("00000000-0000-0000-0000-000000000000"), "We minimize food waste with AI", 2 },
                    { new Guid("c55dfdc6-3560-48e7-bd12-d2c9b4101a55"), new DateTime(2024, 2, 21, 3, 38, 0, 351, DateTimeKind.Local).AddTicks(6528), "We have 3 new openings in the marketing department", null, "Cleantech", new Guid("327ab63f-e42c-4650-98e1-b4af7a8e9bed"), "Expanding marketing team", 1 },
                    { new Guid("cc8d937b-7d14-4410-8ce6-5860a851c225"), new DateTime(2024, 2, 17, 3, 38, 0, 351, DateTimeKind.Local).AddTicks(6722), "After intense preparation we are now ISO certified", null, "Cleantech", new Guid("e2804dfe-56fb-47a5-b57a-0d812ca6d465"), "ISO certification", 3 },
                    { new Guid("e40e836a-83c7-45c2-9c69-6a827db2c96e"), new DateTime(2023, 12, 13, 3, 38, 0, 351, DateTimeKind.Local).AddTicks(6437), "New funding for the startup.", null, "Cleantech", new Guid("327ab63f-e42c-4650-98e1-b4af7a8e9bed"), "Newly funded Startup", 0 },
                    { new Guid("e438cb02-da27-4fd6-bbfe-aecb8883593f"), new DateTime(2023, 12, 21, 3, 38, 0, 351, DateTimeKind.Local).AddTicks(6759), "we are undergoing a reorganization", null, "Cleantech", new Guid("e2804dfe-56fb-47a5-b57a-0d812ca6d465"), "Re-org to ensure competitivness", 1 },
                    { new Guid("f199dd78-1dde-4b2a-b6ba-77a47431d22c"), new DateTime(2024, 2, 10, 3, 38, 0, 351, DateTimeKind.Local).AddTicks(6846), "Forbes Latam named us one of the 20 most promising startups.", null, "AI Farmers", new Guid("00000000-0000-0000-0000-000000000000"), "Forbes LATAM Top 20 startups", 3 },
                    { new Guid("f206e895-d14d-4dab-9a73-9fbeb72ef9ce"), new DateTime(2024, 2, 12, 3, 38, 0, 351, DateTimeKind.Local).AddTicks(6936), "The 100rd restaurant uses our software", null, "BiteAI", new Guid("00000000-0000-0000-0000-000000000000"), "100 customer", 3 },
                    { new Guid("f37c6603-8fb5-48e3-b16f-ae519e862b6b"), new DateTime(2023, 9, 4, 3, 38, 0, 351, DateTimeKind.Local).AddTicks(6507), "The 1000 customer could be onboarded to the platform last week", null, "Cleantech", new Guid("327ab63f-e42c-4650-98e1-b4af7a8e9bed"), "1000th customer", 3 }
                });

            migrationBuilder.InsertData(
                table: "Startups",
                columns: new[] { "Id", "Batch", "Description", "Discipline", "FounderEmail", "Location", "Name", "URI" },
                values: new object[,]
                {
                    { new Guid("327ab63f-e42c-4650-98e1-b4af7a8e9bed"), "2024", "SaaS for cleaning companies", "SaaS", "test.founder@fellowship.com", "Brazil", "Cleantech", "www.cleantech.com" },
                    { new Guid("5ed63ad0-e0fa-4754-bc06-21aecdc37edd"), "2023", "AI for the farming industry", "SaaS", "aiFarmers@email.com", "Argentina", "AI Farmers", "www.farmingwithai.com" },
                    { new Guid("7e1f9a1a-16c0-481c-9215-709d6c801298"), "2022", "Microfibers for efficient materials", "Deeptech", "fibers@email.com", "Ecuador", "Fiberfficient", "www.fiberficcient.com" },
                    { new Guid("86cecd1d-dfb4-4220-a49b-2f8e31e4a03d"), "2024", "Making restaurants more effective with AI", "SaaS", "aiRestaurant@email.com", "Argentina", "BiteAI", "www.biteai.com" },
                    { new Guid("acfb429d-4ba6-4828-9841-a9a9e77b373f"), "2022", "Search engine for lawyers", "Legaltech", "legaltech@email.com", "Ecuador", "SearchLaw", "www.searchlaw.com" },
                    { new Guid("e2804dfe-56fb-47a5-b57a-0d812ca6d465"), "2022", "Medtech for dentists", "Medtech", "medtech@email.com", "Ecuador", "MedDents", "www.medtech.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Founders",
                keyColumn: "Id",
                keyValue: new Guid("3b95a5bb-d135-4dc9-9d48-76cde8876b75"));

            migrationBuilder.DeleteData(
                table: "Founders",
                keyColumn: "Id",
                keyValue: new Guid("5a91f566-37db-4052-b09c-7e569555706a"));

            migrationBuilder.DeleteData(
                table: "Founders",
                keyColumn: "Id",
                keyValue: new Guid("7c999d15-0ced-4f11-87fb-dbd2e9620e49"));

            migrationBuilder.DeleteData(
                table: "Founders",
                keyColumn: "Id",
                keyValue: new Guid("c2584b35-3c07-45f3-aef8-dd885039a837"));

            migrationBuilder.DeleteData(
                table: "Founders",
                keyColumn: "Id",
                keyValue: new Guid("da4c0289-4aca-4c7a-a204-ff46d5e11594"));

            migrationBuilder.DeleteData(
                table: "Founders",
                keyColumn: "Id",
                keyValue: new Guid("dc979906-992e-4412-abb8-cc542ab3a59f"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("022d4dd2-9066-4474-bbf1-05dcbddcb455"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("1af15345-0468-462c-b134-1d6231e83edb"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("1cdd65d0-3ad9-4a29-a865-bff1a945cb2f"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("2bd291d4-5e85-47b9-b542-325f25f4bb7f"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("40e1f91a-f105-4bf2-bcdb-fea11e640c2f"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("4b44b605-0628-48d3-be41-9bf766be14ad"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("566cb036-7a28-4632-a26f-6327e8885842"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("573a3ecd-fcd5-471d-80a2-99b48c933c6a"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("72c50517-3ba2-4212-9ad6-2002139e3881"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("883408e2-f703-405f-91c6-78b3b20f755b"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("ac511d92-4cc3-46fb-b08e-32236f4b76a9"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("c55dfdc6-3560-48e7-bd12-d2c9b4101a55"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("cc8d937b-7d14-4410-8ce6-5860a851c225"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("e40e836a-83c7-45c2-9c69-6a827db2c96e"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("e438cb02-da27-4fd6-bbfe-aecb8883593f"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("f199dd78-1dde-4b2a-b6ba-77a47431d22c"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("f206e895-d14d-4dab-9a73-9fbeb72ef9ce"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("f37c6603-8fb5-48e3-b16f-ae519e862b6b"));

            migrationBuilder.DeleteData(
                table: "Startups",
                keyColumn: "Id",
                keyValue: new Guid("327ab63f-e42c-4650-98e1-b4af7a8e9bed"));

            migrationBuilder.DeleteData(
                table: "Startups",
                keyColumn: "Id",
                keyValue: new Guid("5ed63ad0-e0fa-4754-bc06-21aecdc37edd"));

            migrationBuilder.DeleteData(
                table: "Startups",
                keyColumn: "Id",
                keyValue: new Guid("7e1f9a1a-16c0-481c-9215-709d6c801298"));

            migrationBuilder.DeleteData(
                table: "Startups",
                keyColumn: "Id",
                keyValue: new Guid("86cecd1d-dfb4-4220-a49b-2f8e31e4a03d"));

            migrationBuilder.DeleteData(
                table: "Startups",
                keyColumn: "Id",
                keyValue: new Guid("acfb429d-4ba6-4828-9841-a9a9e77b373f"));

            migrationBuilder.DeleteData(
                table: "Startups",
                keyColumn: "Id",
                keyValue: new Guid("e2804dfe-56fb-47a5-b57a-0d812ca6d465"));

            migrationBuilder.DropColumn(
                name: "StartupId",
                table: "StartupContents");

            migrationBuilder.InsertData(
                table: "Founders",
                columns: new[] { "Id", "Email", "MobileEnabled", "MobileNumber" },
                values: new object[] { new Guid("8584baa2-7afd-4008-aa92-b923cbd6c451"), "test.founder@fellowship.com", false, "1234567" });

            migrationBuilder.InsertData(
                table: "Startups",
                columns: new[] { "Id", "Batch", "Description", "Discipline", "FounderEmail", "Location", "Name", "URI" },
                values: new object[] { new Guid("1bbd959b-659f-49f9-8acc-b37bba1b8b65"), "2024", "SaaS for cleaning companies", "SaaS", "test.founder@fellowship.com", "Brazil", "Cleantech", "www.cleantech.com" });
        }
    }
}
