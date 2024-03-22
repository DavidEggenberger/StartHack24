using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Features.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class crawledcontent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "CrawledContents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Source = table.Column<int>(type: "int", nullable: false),
                    Startup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrawledContents", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Founders",
                columns: new[] { "Id", "Email", "MobileEnabled", "MobileNumber" },
                values: new object[,]
                {
                    { new Guid("02211d91-2215-47b2-a39c-61abef1e7cf7"), "medtech@email.com", false, "45454556" },
                    { new Guid("1da64406-50e9-4f72-9cea-1c76fa30abca"), "aiFarmers@email.com", false, "45454556" },
                    { new Guid("69bb9ac9-1c93-416e-83f9-9eae84026cd5"), "fibers@email.com", false, "45454556" },
                    { new Guid("7f2de59f-79b1-4d2c-a9f1-b6fae6a6be82"), "legaltech@email.com", false, "45454556" },
                    { new Guid("a1a0e845-993a-45d6-84d9-c9e9cb5c400d"), "test.founder@fellowship.com", false, "45454556" },
                    { new Guid("c6671ed8-c63c-4e75-aa11-ea51468a97f2"), "aiRestaurant@email.com", false, "45454556" }
                });

            migrationBuilder.InsertData(
                table: "StartupContents",
                columns: new[] { "Id", "Date", "Description", "Domain", "Startup", "StartupId", "Title", "Type" },
                values: new object[,]
                {
                    { new Guid("1bc6a47a-133f-4877-bede-fce46cc78e10"), new DateTime(2023, 11, 23, 4, 24, 20, 859, DateTimeKind.Local).AddTicks(6133), "We are actively searching for new investors", null, "BiteAI", new Guid("7f03019b-cc87-4b20-87e1-9dce9c2ed9bc"), "Searching for new investors", 0 },
                    { new Guid("2ac126e0-f763-4d0c-90b3-f2270e10dce5"), new DateTime(2024, 2, 22, 4, 24, 20, 859, DateTimeKind.Local).AddTicks(5842), "we are saving emissons by working remote", null, "Cleantech", new Guid("72576cab-5af9-4e22-9a96-1b2e5c4e2c56"), "working remote saves emissions", 2 },
                    { new Guid("32f8bf30-9b1b-41c4-a39b-995456ac0b21"), new DateTime(2023, 8, 15, 4, 24, 20, 859, DateTimeKind.Local).AddTicks(6115), "We now operate with a Co-Ceo", null, "BiteAI", new Guid("7f03019b-cc87-4b20-87e1-9dce9c2ed9bc"), "Starting with 2 Co-Ceos", 1 },
                    { new Guid("34bc5ade-df98-4b7d-b911-dabda2100092"), new DateTime(2024, 3, 21, 4, 24, 20, 859, DateTimeKind.Local).AddTicks(5943), "Our engineering team looks for promising colleagues.", null, "AI Farmers", new Guid("970188fd-1f01-4a25-9322-202abd5bcf54"), "Open jobs in engineering", 1 },
                    { new Guid("39094507-a62d-4a7c-8817-9c5969a34063"), new DateTime(2024, 3, 15, 4, 24, 20, 859, DateTimeKind.Local).AddTicks(5926), "We raised our 2 million Series A round", null, "AI Farmers", new Guid("970188fd-1f01-4a25-9322-202abd5bcf54"), "Big series A", 0 },
                    { new Guid("44c2dbfd-a70f-4e95-841b-094ec2660fff"), new DateTime(2023, 12, 13, 4, 24, 20, 859, DateTimeKind.Local).AddTicks(5960), "We are currently managing more then 100 square kilometres of farm land", null, "AI Farmers", new Guid("970188fd-1f01-4a25-9322-202abd5bcf54"), "Managing more then 100 square kilometres of farm land", 3 },
                    { new Guid("561683c8-24b3-4f18-b382-59685382441c"), new DateTime(2024, 3, 19, 4, 24, 20, 859, DateTimeKind.Local).AddTicks(5767), "We could reduce our ecological footprint", null, "Cleantech", new Guid("72576cab-5af9-4e22-9a96-1b2e5c4e2c56"), "Succesfully reduced carbon footprint", 2 },
                    { new Guid("67f6343d-0ead-4a42-8b58-6ace8c4f210e"), new DateTime(2024, 2, 21, 4, 24, 20, 859, DateTimeKind.Local).AddTicks(5657), "We have 3 new openings in the marketing department", null, "Cleantech", new Guid("72576cab-5af9-4e22-9a96-1b2e5c4e2c56"), "Expanding marketing team", 1 },
                    { new Guid("7181f3e0-f70b-4cd8-8ef0-70482c845cac"), new DateTime(2024, 2, 17, 4, 24, 20, 859, DateTimeKind.Local).AddTicks(5787), "After intense preparation we are now ISO certified", null, "Cleantech", new Guid("72576cab-5af9-4e22-9a96-1b2e5c4e2c56"), "ISO certification", 3 },
                    { new Guid("791f74af-6ef6-437f-8916-cb59ebfbd2e8"), new DateTime(2023, 12, 13, 4, 24, 20, 859, DateTimeKind.Local).AddTicks(5550), "New funding for the startup.", null, "Cleantech", new Guid("72576cab-5af9-4e22-9a96-1b2e5c4e2c56"), "Newly funded Startup", 0 },
                    { new Guid("7ce0ac83-1b2e-46b0-86af-8a28c083a0c5"), new DateTime(2024, 1, 12, 4, 24, 20, 859, DateTimeKind.Local).AddTicks(5728), "We have 3 new openings in the finance department", null, "MedDents", new Guid("3258411f-21ba-4d80-91b1-19225ce3b925"), "Bigger finance team", 1 },
                    { new Guid("7d71ee19-9481-46af-bd6b-a3e84c7118a9"), new DateTime(2023, 12, 24, 4, 24, 20, 859, DateTimeKind.Local).AddTicks(5675), "From now on, we visit all our customers by train", null, "Cleantech", new Guid("72576cab-5af9-4e22-9a96-1b2e5c4e2c56"), "Taking the train for business tripps", 2 },
                    { new Guid("88b2aff9-5905-4ec1-b958-963cdef9c4b3"), new DateTime(2023, 12, 3, 4, 24, 20, 859, DateTimeKind.Local).AddTicks(5749), "We have a new partner manager", null, "MedDents", new Guid("3258411f-21ba-4d80-91b1-19225ce3b925"), "Welcoming new faces", 1 },
                    { new Guid("8dc37ae0-89b2-42d7-b363-b48a1b34493a"), new DateTime(2024, 3, 13, 4, 24, 20, 859, DateTimeKind.Local).AddTicks(5859), "we are saving emissons by working remote", null, "Cleantech", new Guid("72576cab-5af9-4e22-9a96-1b2e5c4e2c56"), "working remote saves emissions", 2 },
                    { new Guid("9c39f7d4-d432-428b-b7c5-f3242f8cebd0"), new DateTime(2023, 9, 4, 4, 24, 20, 859, DateTimeKind.Local).AddTicks(5636), "The 1000 customer could be onboarded to the platform last week", null, "Cleantech", new Guid("72576cab-5af9-4e22-9a96-1b2e5c4e2c56"), "1000th customer", 3 },
                    { new Guid("9f7a2869-2e3d-4f01-8ebf-9a23d0cbaa65"), new DateTime(2024, 2, 27, 4, 24, 20, 859, DateTimeKind.Local).AddTicks(6200), "We are now partnering with charities", null, "BiteAI", new Guid("a362c026-adf5-4d71-a490-1887b45f784a"), "Partnerin with charities", 2 },
                    { new Guid("a71f30bf-06e0-4a99-be08-0190c407b8ca"), new DateTime(2024, 1, 15, 4, 24, 20, 859, DateTimeKind.Local).AddTicks(6183), "We are officially licensed for use in courts", null, "BiteAI", new Guid("a362c026-adf5-4d71-a490-1887b45f784a"), "Licensed for use in courts", 3 },
                    { new Guid("b12d264b-2c5e-4df9-a554-34d51f571e0a"), new DateTime(2024, 2, 27, 4, 24, 20, 859, DateTimeKind.Local).AddTicks(6250), "We are enabling scientific breakthroughs", null, "BiteAI", new Guid("fd621f64-1564-43f0-8e45-3a0662486708"), "Enabling scientific breakthroughs", 2 },
                    { new Guid("b959bf9e-b980-416a-acf5-970dde68c74e"), new DateTime(2024, 2, 1, 4, 24, 20, 859, DateTimeKind.Local).AddTicks(5978), "We are developping are more resilient type of seeds together with our parterns", null, "AI Farmers", new Guid("970188fd-1f01-4a25-9322-202abd5bcf54"), "Developing more resilient seed type", 2 },
                    { new Guid("bd61ceed-085c-4934-adeb-3de3ee0dc644"), new DateTime(2024, 2, 29, 4, 24, 20, 859, DateTimeKind.Local).AddTicks(6096), "With our AI we can help in saving emissions", null, "BiteAI", new Guid("7f03019b-cc87-4b20-87e1-9dce9c2ed9bc"), "We minimize food waste with AI", 2 },
                    { new Guid("e3d3ac22-2c28-49f3-b6b7-2bce9c30362c"), new DateTime(2022, 11, 16, 4, 24, 20, 859, DateTimeKind.Local).AddTicks(5805), "Successfully mitigated a hacker attack", null, "Cleantech", new Guid("72576cab-5af9-4e22-9a96-1b2e5c4e2c56"), "Prevented a hacker attack", 3 },
                    { new Guid("e4b0d8c1-4ab8-4dc3-b96d-6c6c05bcb489"), new DateTime(2024, 2, 10, 4, 24, 20, 859, DateTimeKind.Local).AddTicks(5907), "Forbes Latam named us one of the 20 most promising startups.", null, "AI Farmers", new Guid("970188fd-1f01-4a25-9322-202abd5bcf54"), "Forbes LATAM Top 20 startups", 3 },
                    { new Guid("e5ed2c3b-6f0e-4946-9d34-e7a9eeee33f6"), new DateTime(2023, 12, 21, 4, 24, 20, 859, DateTimeKind.Local).AddTicks(5824), "we are undergoing a reorganization", null, "Cleantech", new Guid("72576cab-5af9-4e22-9a96-1b2e5c4e2c56"), "Re-org to ensure competitivness", 1 },
                    { new Guid("ef3d8454-2b80-4251-b51b-63d4f2b2f161"), new DateTime(2024, 2, 12, 4, 24, 20, 859, DateTimeKind.Local).AddTicks(6077), "The 100rd restaurant uses our software", null, "BiteAI", new Guid("7f03019b-cc87-4b20-87e1-9dce9c2ed9bc"), "100 customer", 3 }
                });

            migrationBuilder.InsertData(
                table: "Startups",
                columns: new[] { "Id", "Batch", "Description", "Discipline", "FounderEmail", "Location", "Name", "URI" },
                values: new object[,]
                {
                    { new Guid("3258411f-21ba-4d80-91b1-19225ce3b925"), "2022", "Medtech for dentists", "Medtech", "medtech@email.com", "Ecuador", "MedDents", "www.medtech.com" },
                    { new Guid("72576cab-5af9-4e22-9a96-1b2e5c4e2c56"), "2024", "SaaS for cleaning companies", "SaaS", "test.founder@fellowship.com", "Brazil", "Cleantech", "www.cleantech.com" },
                    { new Guid("7f03019b-cc87-4b20-87e1-9dce9c2ed9bc"), "2024", "Making restaurants more effective with AI", "SaaS", "aiRestaurant@email.com", "Argentina", "BiteAI", "www.biteai.com" },
                    { new Guid("970188fd-1f01-4a25-9322-202abd5bcf54"), "2023", "AI for the farming industry", "SaaS", "aiFarmers@email.com", "Argentina", "AI Farmers", "www.farmingwithai.com" },
                    { new Guid("a362c026-adf5-4d71-a490-1887b45f784a"), "2022", "Search engine for lawyers", "Legaltech", "legaltech@email.com", "Ecuador", "SearchLaw", "www.searchlaw.com" },
                    { new Guid("fd621f64-1564-43f0-8e45-3a0662486708"), "2022", "Microfibers for efficient materials", "Deeptech", "fibers@email.com", "Ecuador", "Fiberfficient", "www.fiberficcient.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CrawledContents");

            migrationBuilder.DeleteData(
                table: "Founders",
                keyColumn: "Id",
                keyValue: new Guid("02211d91-2215-47b2-a39c-61abef1e7cf7"));

            migrationBuilder.DeleteData(
                table: "Founders",
                keyColumn: "Id",
                keyValue: new Guid("1da64406-50e9-4f72-9cea-1c76fa30abca"));

            migrationBuilder.DeleteData(
                table: "Founders",
                keyColumn: "Id",
                keyValue: new Guid("69bb9ac9-1c93-416e-83f9-9eae84026cd5"));

            migrationBuilder.DeleteData(
                table: "Founders",
                keyColumn: "Id",
                keyValue: new Guid("7f2de59f-79b1-4d2c-a9f1-b6fae6a6be82"));

            migrationBuilder.DeleteData(
                table: "Founders",
                keyColumn: "Id",
                keyValue: new Guid("a1a0e845-993a-45d6-84d9-c9e9cb5c400d"));

            migrationBuilder.DeleteData(
                table: "Founders",
                keyColumn: "Id",
                keyValue: new Guid("c6671ed8-c63c-4e75-aa11-ea51468a97f2"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("1bc6a47a-133f-4877-bede-fce46cc78e10"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("2ac126e0-f763-4d0c-90b3-f2270e10dce5"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("32f8bf30-9b1b-41c4-a39b-995456ac0b21"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("34bc5ade-df98-4b7d-b911-dabda2100092"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("39094507-a62d-4a7c-8817-9c5969a34063"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("44c2dbfd-a70f-4e95-841b-094ec2660fff"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("561683c8-24b3-4f18-b382-59685382441c"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("67f6343d-0ead-4a42-8b58-6ace8c4f210e"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("7181f3e0-f70b-4cd8-8ef0-70482c845cac"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("791f74af-6ef6-437f-8916-cb59ebfbd2e8"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("7ce0ac83-1b2e-46b0-86af-8a28c083a0c5"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("7d71ee19-9481-46af-bd6b-a3e84c7118a9"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("88b2aff9-5905-4ec1-b958-963cdef9c4b3"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("8dc37ae0-89b2-42d7-b363-b48a1b34493a"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("9c39f7d4-d432-428b-b7c5-f3242f8cebd0"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("9f7a2869-2e3d-4f01-8ebf-9a23d0cbaa65"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("a71f30bf-06e0-4a99-be08-0190c407b8ca"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("b12d264b-2c5e-4df9-a554-34d51f571e0a"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("b959bf9e-b980-416a-acf5-970dde68c74e"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("bd61ceed-085c-4934-adeb-3de3ee0dc644"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("e3d3ac22-2c28-49f3-b6b7-2bce9c30362c"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("e4b0d8c1-4ab8-4dc3-b96d-6c6c05bcb489"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("e5ed2c3b-6f0e-4946-9d34-e7a9eeee33f6"));

            migrationBuilder.DeleteData(
                table: "StartupContents",
                keyColumn: "Id",
                keyValue: new Guid("ef3d8454-2b80-4251-b51b-63d4f2b2f161"));

            migrationBuilder.DeleteData(
                table: "Startups",
                keyColumn: "Id",
                keyValue: new Guid("3258411f-21ba-4d80-91b1-19225ce3b925"));

            migrationBuilder.DeleteData(
                table: "Startups",
                keyColumn: "Id",
                keyValue: new Guid("72576cab-5af9-4e22-9a96-1b2e5c4e2c56"));

            migrationBuilder.DeleteData(
                table: "Startups",
                keyColumn: "Id",
                keyValue: new Guid("7f03019b-cc87-4b20-87e1-9dce9c2ed9bc"));

            migrationBuilder.DeleteData(
                table: "Startups",
                keyColumn: "Id",
                keyValue: new Guid("970188fd-1f01-4a25-9322-202abd5bcf54"));

            migrationBuilder.DeleteData(
                table: "Startups",
                keyColumn: "Id",
                keyValue: new Guid("a362c026-adf5-4d71-a490-1887b45f784a"));

            migrationBuilder.DeleteData(
                table: "Startups",
                keyColumn: "Id",
                keyValue: new Guid("fd621f64-1564-43f0-8e45-3a0662486708"));

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
    }
}
