using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Features.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class seeding2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Founders",
                columns: new[] { "Id", "Email", "MobileEnabled", "MobileNumber" },
                values: new object[,]
                {
                    { new Guid("763be86f-f860-4aca-bb23-ee08decd7c38"), "aiFarmers@email.com", false, "45454556" },
                    { new Guid("7e5c59f5-f904-481b-a7f3-3ce20d8b5557"), "legaltech@email.com", false, "45454556" },
                    { new Guid("bf002121-61aa-4cc9-8d9f-cd25eea58227"), "aiRestaurant@email.com", false, "45454556" },
                    { new Guid("bfbfc654-8ead-482b-858b-b65ffcd87717"), "test.founder@fellowship.com", false, "45454556" },
                    { new Guid("d21bc5d0-ee5d-4bcb-8e8f-a544d6154306"), "medtech@email.com", false, "45454556" },
                    { new Guid("ee6ea0ae-65fd-4886-b5b8-5a02cd8455e9"), "fibers@email.com", false, "45454556" }
                });

            migrationBuilder.InsertData(
                table: "StartupContents",
                columns: new[] { "Id", "Date", "Description", "Domain", "Startup", "StartupId", "Title", "Type" },
                values: new object[,]
                {
                    { new Guid("07ff0f8b-f795-40f2-a853-174a0c7981db"), new DateTime(2023, 9, 4, 3, 54, 59, 242, DateTimeKind.Local).AddTicks(4058), "The 1000 customer could be onboarded to the platform last week", null, "Cleantech", new Guid("e584d879-299a-48ad-921c-308e70a37e7a"), "1000th customer", 3 },
                    { new Guid("1ac6c282-e0a6-4b21-9684-4a52d18df113"), new DateTime(2024, 2, 17, 3, 54, 59, 242, DateTimeKind.Local).AddTicks(4228), "After intense preparation we are now ISO certified", null, "Cleantech", new Guid("e584d879-299a-48ad-921c-308e70a37e7a"), "ISO certification", 3 },
                    { new Guid("1b8f3d0c-4245-4939-bdb6-da602a67ba15"), new DateTime(2024, 2, 22, 3, 54, 59, 242, DateTimeKind.Local).AddTicks(4291), "we are saving emissons by working remote", null, "Cleantech", new Guid("e584d879-299a-48ad-921c-308e70a37e7a"), "working remote saves emissions", 2 },
                    { new Guid("21b6fa02-3b44-42f6-8391-033ba7e2272a"), new DateTime(2024, 2, 27, 3, 54, 59, 242, DateTimeKind.Local).AddTicks(4707), "We are enabling scientific breakthroughs", null, "BiteAI", new Guid("d5ab19ef-1208-4b7c-9b41-bdb796eaab21"), "Enabling scientific breakthroughs", 2 },
                    { new Guid("25d5f9a0-f152-4a7d-a27d-0fdaefcd5e8b"), new DateTime(2024, 1, 15, 3, 54, 59, 242, DateTimeKind.Local).AddTicks(4640), "We are officially licensed for use in courts", null, "BiteAI", new Guid("966abdbd-af82-4763-8e8f-6b42d935f99c"), "Licensed for use in courts", 3 },
                    { new Guid("2648411b-1372-49c4-8155-3ac24ca49657"), new DateTime(2024, 3, 21, 3, 54, 59, 242, DateTimeKind.Local).AddTicks(4398), "Our engineering team looks for promising colleagues.", null, "AI Farmers", new Guid("4106d7a6-81f9-4ecf-8041-73671a4831f2"), "Open jobs in engineering", 1 },
                    { new Guid("2ed84318-10a3-464d-85cd-0755fe86bcaa"), new DateTime(2024, 2, 21, 3, 54, 59, 242, DateTimeKind.Local).AddTicks(4081), "We have 3 new openings in the marketing department", null, "Cleantech", new Guid("e584d879-299a-48ad-921c-308e70a37e7a"), "Expanding marketing team", 1 },
                    { new Guid("317f60fc-a5ea-43d6-9c7f-4757c8d3f50e"), new DateTime(2024, 2, 10, 3, 54, 59, 242, DateTimeKind.Local).AddTicks(4361), "Forbes Latam named us one of the 20 most promising startups.", null, "AI Farmers", new Guid("4106d7a6-81f9-4ecf-8041-73671a4831f2"), "Forbes LATAM Top 20 startups", 3 },
                    { new Guid("4e236406-7294-465c-b87f-f4077158ac48"), new DateTime(2023, 12, 13, 3, 54, 59, 242, DateTimeKind.Local).AddTicks(4419), "We are currently managing more then 100 square kilometres of farm land", null, "AI Farmers", new Guid("4106d7a6-81f9-4ecf-8041-73671a4831f2"), "Managing more then 100 square kilometres of farm land", 3 },
                    { new Guid("65a8ba59-43b3-4497-b0b1-0854284f7ecc"), new DateTime(2022, 11, 16, 3, 54, 59, 242, DateTimeKind.Local).AddTicks(4248), "Successfully mitigated a hacker attack", null, "Cleantech", new Guid("e584d879-299a-48ad-921c-308e70a37e7a"), "Prevented a hacker attack", 3 },
                    { new Guid("68a41238-1e87-4c34-a080-c8541319de6b"), new DateTime(2023, 8, 15, 3, 54, 59, 242, DateTimeKind.Local).AddTicks(4565), "We now operate with a Co-Ceo", null, "BiteAI", new Guid("35572f3b-baba-485b-b540-1aca8540d984"), "Starting with 2 Co-Ceos", 1 },
                    { new Guid("6944c512-1ea2-424b-9f10-d45cdbaac1b7"), new DateTime(2024, 3, 15, 3, 54, 59, 242, DateTimeKind.Local).AddTicks(4379), "We raised our 2 million Series A round", null, "AI Farmers", new Guid("4106d7a6-81f9-4ecf-8041-73671a4831f2"), "Big series A", 0 },
                    { new Guid("7340c653-cdc0-427b-a14b-ad4e4bf56e16"), new DateTime(2023, 12, 24, 3, 54, 59, 242, DateTimeKind.Local).AddTicks(4115), "From now on, we visit all our customers by train", null, "Cleantech", new Guid("e584d879-299a-48ad-921c-308e70a37e7a"), "Taking the train for business tripps", 2 },
                    { new Guid("7b6ecbf2-220a-4198-a8a5-1ae573981d01"), new DateTime(2023, 11, 23, 3, 54, 59, 242, DateTimeKind.Local).AddTicks(4586), "We are actively searching for new investors", null, "BiteAI", new Guid("35572f3b-baba-485b-b540-1aca8540d984"), "Searching for new investors", 0 },
                    { new Guid("8066dde0-b35d-40be-b5a7-df9854a6142e"), new DateTime(2024, 2, 12, 3, 54, 59, 242, DateTimeKind.Local).AddTicks(4489), "The 100rd restaurant uses our software", null, "BiteAI", new Guid("35572f3b-baba-485b-b540-1aca8540d984"), "100 customer", 3 },
                    { new Guid("8519a75f-c327-4451-bca0-2e2c658c838c"), new DateTime(2024, 2, 1, 3, 54, 59, 242, DateTimeKind.Local).AddTicks(4439), "We are developping are more resilient type of seeds together with our parterns", null, "AI Farmers", new Guid("4106d7a6-81f9-4ecf-8041-73671a4831f2"), "Developing more resilient seed type", 2 },
                    { new Guid("932abc40-e590-4abb-a58b-336eeb8f1645"), new DateTime(2024, 2, 27, 3, 54, 59, 242, DateTimeKind.Local).AddTicks(4659), "We are now partnering with charities", null, "BiteAI", new Guid("966abdbd-af82-4763-8e8f-6b42d935f99c"), "Partnerin with charities", 2 },
                    { new Guid("93f41e33-75aa-4cd3-bf5b-dbaa603c51f3"), new DateTime(2024, 2, 29, 3, 54, 59, 242, DateTimeKind.Local).AddTicks(4509), "With our AI we can help in saving emissions", null, "BiteAI", new Guid("35572f3b-baba-485b-b540-1aca8540d984"), "We minimize food waste with AI", 2 },
                    { new Guid("96bda7b5-d9d2-4a63-919e-5152dec552ce"), new DateTime(2024, 3, 13, 3, 54, 59, 242, DateTimeKind.Local).AddTicks(4311), "we are saving emissons by working remote", null, "Cleantech", new Guid("e584d879-299a-48ad-921c-308e70a37e7a"), "working remote saves emissions", 2 },
                    { new Guid("bc9f95c0-1b2f-4366-be0e-c9f21982cc98"), new DateTime(2023, 12, 3, 3, 54, 59, 242, DateTimeKind.Local).AddTicks(4190), "We have a new partner manager", null, "MedDents", new Guid("22c22178-7d76-4ddc-94ba-6e773de6f9a1"), "Welcoming new faces", 1 },
                    { new Guid("bd45aaa2-6c4a-43ab-a0e2-28754e438d8a"), new DateTime(2024, 3, 19, 3, 54, 59, 242, DateTimeKind.Local).AddTicks(4210), "We could reduce our ecological footprint", null, "Cleantech", new Guid("e584d879-299a-48ad-921c-308e70a37e7a"), "Succesfully reduced carbon footprint", 2 },
                    { new Guid("c6d41f94-ac4b-4876-aa82-1674020e9830"), new DateTime(2023, 12, 13, 3, 54, 59, 242, DateTimeKind.Local).AddTicks(3949), "New funding for the startup.", null, "Cleantech", new Guid("e584d879-299a-48ad-921c-308e70a37e7a"), "Newly funded Startup", 0 },
                    { new Guid("d823e045-c991-48e0-afe0-9c7971a234a5"), new DateTime(2024, 1, 12, 3, 54, 59, 242, DateTimeKind.Local).AddTicks(4167), "We have 3 new openings in the finance department", null, "MedDents", new Guid("22c22178-7d76-4ddc-94ba-6e773de6f9a1"), "Bigger finance team", 1 },
                    { new Guid("f434d8c2-29f1-47bc-b749-2f20870709d8"), new DateTime(2023, 12, 21, 3, 54, 59, 242, DateTimeKind.Local).AddTicks(4271), "we are undergoing a reorganization", null, "Cleantech", new Guid("e584d879-299a-48ad-921c-308e70a37e7a"), "Re-org to ensure competitivness", 1 }
                });

            migrationBuilder.InsertData(
                table: "Startups",
                columns: new[] { "Id", "Batch", "Description", "Discipline", "FounderEmail", "Location", "Name", "URI" },
                values: new object[,]
                {
                    { new Guid("22c22178-7d76-4ddc-94ba-6e773de6f9a1"), "2022", "Medtech for dentists", "Medtech", "medtech@email.com", "Ecuador", "MedDents", "www.medtech.com" },
                    { new Guid("35572f3b-baba-485b-b540-1aca8540d984"), "2024", "Making restaurants more effective with AI", "SaaS", "aiRestaurant@email.com", "Argentina", "BiteAI", "www.biteai.com" },
                    { new Guid("4106d7a6-81f9-4ecf-8041-73671a4831f2"), "2023", "AI for the farming industry", "SaaS", "aiFarmers@email.com", "Argentina", "AI Farmers", "www.farmingwithai.com" },
                    { new Guid("966abdbd-af82-4763-8e8f-6b42d935f99c"), "2022", "Search engine for lawyers", "Legaltech", "legaltech@email.com", "Ecuador", "SearchLaw", "www.searchlaw.com" },
                    { new Guid("d5ab19ef-1208-4b7c-9b41-bdb796eaab21"), "2022", "Microfibers for efficient materials", "Deeptech", "fibers@email.com", "Ecuador", "Fiberfficient", "www.fiberficcient.com" },
                    { new Guid("e584d879-299a-48ad-921c-308e70a37e7a"), "2024", "SaaS for cleaning companies", "SaaS", "test.founder@fellowship.com", "Brazil", "Cleantech", "www.cleantech.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Founders",
                keyColumn: "Id",
                keyValue: new Guid("763be86f-f860-4aca-bb23-ee08decd7c38"));

            migrationBuilder.DeleteData(
                table: "Founders",
                keyColumn: "Id",
                keyValue: new Guid("7e5c59f5-f904-481b-a7f3-3ce20d8b5557"));

            migrationBuilder.DeleteData(
                table: "Founders",
                keyColumn: "Id",
                keyValue: new Guid("bf002121-61aa-4cc9-8d9f-cd25eea58227"));

            migrationBuilder.DeleteData(
                table: "Founders",
                keyColumn: "Id",
                keyValue: new Guid("bfbfc654-8ead-482b-858b-b65ffcd87717"));

            migrationBuilder.DeleteData(
                table: "Founders",
                keyColumn: "Id",
                keyValue: new Guid("d21bc5d0-ee5d-4bcb-8e8f-a544d6154306"));

            migrationBuilder.DeleteData(
                table: "Founders",
                keyColumn: "Id",
                keyValue: new Guid("ee6ea0ae-65fd-4886-b5b8-5a02cd8455e9"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("07ff0f8b-f795-40f2-a853-174a0c7981db"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("1ac6c282-e0a6-4b21-9684-4a52d18df113"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("1b8f3d0c-4245-4939-bdb6-da602a67ba15"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("21b6fa02-3b44-42f6-8391-033ba7e2272a"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("25d5f9a0-f152-4a7d-a27d-0fdaefcd5e8b"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("2648411b-1372-49c4-8155-3ac24ca49657"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("2ed84318-10a3-464d-85cd-0755fe86bcaa"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("317f60fc-a5ea-43d6-9c7f-4757c8d3f50e"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("4e236406-7294-465c-b87f-f4077158ac48"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("65a8ba59-43b3-4497-b0b1-0854284f7ecc"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("68a41238-1e87-4c34-a080-c8541319de6b"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("6944c512-1ea2-424b-9f10-d45cdbaac1b7"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("7340c653-cdc0-427b-a14b-ad4e4bf56e16"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("7b6ecbf2-220a-4198-a8a5-1ae573981d01"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("8066dde0-b35d-40be-b5a7-df9854a6142e"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("8519a75f-c327-4451-bca0-2e2c658c838c"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("932abc40-e590-4abb-a58b-336eeb8f1645"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("93f41e33-75aa-4cd3-bf5b-dbaa603c51f3"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("96bda7b5-d9d2-4a63-919e-5152dec552ce"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("bc9f95c0-1b2f-4366-be0e-c9f21982cc98"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("bd45aaa2-6c4a-43ab-a0e2-28754e438d8a"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("c6d41f94-ac4b-4876-aa82-1674020e9830"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("d823e045-c991-48e0-afe0-9c7971a234a5"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("f434d8c2-29f1-47bc-b749-2f20870709d8"));

            migrationBuilder.DeleteData(
                table: "Startups",
                keyColumn: "Id",
                keyValue: new Guid("22c22178-7d76-4ddc-94ba-6e773de6f9a1"));

            migrationBuilder.DeleteData(
                table: "Startups",
                keyColumn: "Id",
                keyValue: new Guid("35572f3b-baba-485b-b540-1aca8540d984"));

            migrationBuilder.DeleteData(
                table: "Startups",
                keyColumn: "Id",
                keyValue: new Guid("4106d7a6-81f9-4ecf-8041-73671a4831f2"));

            migrationBuilder.DeleteData(
                table: "Startups",
                keyColumn: "Id",
                keyValue: new Guid("966abdbd-af82-4763-8e8f-6b42d935f99c"));

            migrationBuilder.DeleteData(
                table: "Startups",
                keyColumn: "Id",
                keyValue: new Guid("d5ab19ef-1208-4b7c-9b41-bdb796eaab21"));

            migrationBuilder.DeleteData(
                table: "Startups",
                keyColumn: "Id",
                keyValue: new Guid("e584d879-299a-48ad-921c-308e70a37e7a"));

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
    }
}
