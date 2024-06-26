﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Server.Features.EFCore;

#nullable disable

namespace Server.Features.EFCore.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240322032421_crawledcontent")]
    partial class crawledcontent
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Server.Features.ContentFeed.CrawledContent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Source")
                        .HasColumnType("int");

                    b.Property<string>("Startup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CrawledContents");
                });

            modelBuilder.Entity("Server.Features.ContentFeed.StartupContent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Domain")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Startup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("StartupId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("StartupContents");

                    b.HasData(
                        new
                        {
                            Id = new Guid("791f74af-6ef6-437f-8916-cb59ebfbd2e8"),
                            Date = new DateTime(2023, 12, 13, 4, 24, 20, 859, DateTimeKind.Local).AddTicks(5550),
                            Description = "New funding for the startup.",
                            Startup = "Cleantech",
                            StartupId = new Guid("72576cab-5af9-4e22-9a96-1b2e5c4e2c56"),
                            Title = "Newly funded Startup",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("9c39f7d4-d432-428b-b7c5-f3242f8cebd0"),
                            Date = new DateTime(2023, 9, 4, 4, 24, 20, 859, DateTimeKind.Local).AddTicks(5636),
                            Description = "The 1000 customer could be onboarded to the platform last week",
                            Startup = "Cleantech",
                            StartupId = new Guid("72576cab-5af9-4e22-9a96-1b2e5c4e2c56"),
                            Title = "1000th customer",
                            Type = 3
                        },
                        new
                        {
                            Id = new Guid("67f6343d-0ead-4a42-8b58-6ace8c4f210e"),
                            Date = new DateTime(2024, 2, 21, 4, 24, 20, 859, DateTimeKind.Local).AddTicks(5657),
                            Description = "We have 3 new openings in the marketing department",
                            Startup = "Cleantech",
                            StartupId = new Guid("72576cab-5af9-4e22-9a96-1b2e5c4e2c56"),
                            Title = "Expanding marketing team",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("7d71ee19-9481-46af-bd6b-a3e84c7118a9"),
                            Date = new DateTime(2023, 12, 24, 4, 24, 20, 859, DateTimeKind.Local).AddTicks(5675),
                            Description = "From now on, we visit all our customers by train",
                            Startup = "Cleantech",
                            StartupId = new Guid("72576cab-5af9-4e22-9a96-1b2e5c4e2c56"),
                            Title = "Taking the train for business tripps",
                            Type = 2
                        },
                        new
                        {
                            Id = new Guid("7ce0ac83-1b2e-46b0-86af-8a28c083a0c5"),
                            Date = new DateTime(2024, 1, 12, 4, 24, 20, 859, DateTimeKind.Local).AddTicks(5728),
                            Description = "We have 3 new openings in the finance department",
                            Startup = "MedDents",
                            StartupId = new Guid("3258411f-21ba-4d80-91b1-19225ce3b925"),
                            Title = "Bigger finance team",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("88b2aff9-5905-4ec1-b958-963cdef9c4b3"),
                            Date = new DateTime(2023, 12, 3, 4, 24, 20, 859, DateTimeKind.Local).AddTicks(5749),
                            Description = "We have a new partner manager",
                            Startup = "MedDents",
                            StartupId = new Guid("3258411f-21ba-4d80-91b1-19225ce3b925"),
                            Title = "Welcoming new faces",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("561683c8-24b3-4f18-b382-59685382441c"),
                            Date = new DateTime(2024, 3, 19, 4, 24, 20, 859, DateTimeKind.Local).AddTicks(5767),
                            Description = "We could reduce our ecological footprint",
                            Startup = "Cleantech",
                            StartupId = new Guid("72576cab-5af9-4e22-9a96-1b2e5c4e2c56"),
                            Title = "Succesfully reduced carbon footprint",
                            Type = 2
                        },
                        new
                        {
                            Id = new Guid("7181f3e0-f70b-4cd8-8ef0-70482c845cac"),
                            Date = new DateTime(2024, 2, 17, 4, 24, 20, 859, DateTimeKind.Local).AddTicks(5787),
                            Description = "After intense preparation we are now ISO certified",
                            Startup = "Cleantech",
                            StartupId = new Guid("72576cab-5af9-4e22-9a96-1b2e5c4e2c56"),
                            Title = "ISO certification",
                            Type = 3
                        },
                        new
                        {
                            Id = new Guid("e3d3ac22-2c28-49f3-b6b7-2bce9c30362c"),
                            Date = new DateTime(2022, 11, 16, 4, 24, 20, 859, DateTimeKind.Local).AddTicks(5805),
                            Description = "Successfully mitigated a hacker attack",
                            Startup = "Cleantech",
                            StartupId = new Guid("72576cab-5af9-4e22-9a96-1b2e5c4e2c56"),
                            Title = "Prevented a hacker attack",
                            Type = 3
                        },
                        new
                        {
                            Id = new Guid("e5ed2c3b-6f0e-4946-9d34-e7a9eeee33f6"),
                            Date = new DateTime(2023, 12, 21, 4, 24, 20, 859, DateTimeKind.Local).AddTicks(5824),
                            Description = "we are undergoing a reorganization",
                            Startup = "Cleantech",
                            StartupId = new Guid("72576cab-5af9-4e22-9a96-1b2e5c4e2c56"),
                            Title = "Re-org to ensure competitivness",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("2ac126e0-f763-4d0c-90b3-f2270e10dce5"),
                            Date = new DateTime(2024, 2, 22, 4, 24, 20, 859, DateTimeKind.Local).AddTicks(5842),
                            Description = "we are saving emissons by working remote",
                            Startup = "Cleantech",
                            StartupId = new Guid("72576cab-5af9-4e22-9a96-1b2e5c4e2c56"),
                            Title = "working remote saves emissions",
                            Type = 2
                        },
                        new
                        {
                            Id = new Guid("8dc37ae0-89b2-42d7-b363-b48a1b34493a"),
                            Date = new DateTime(2024, 3, 13, 4, 24, 20, 859, DateTimeKind.Local).AddTicks(5859),
                            Description = "we are saving emissons by working remote",
                            Startup = "Cleantech",
                            StartupId = new Guid("72576cab-5af9-4e22-9a96-1b2e5c4e2c56"),
                            Title = "working remote saves emissions",
                            Type = 2
                        },
                        new
                        {
                            Id = new Guid("e4b0d8c1-4ab8-4dc3-b96d-6c6c05bcb489"),
                            Date = new DateTime(2024, 2, 10, 4, 24, 20, 859, DateTimeKind.Local).AddTicks(5907),
                            Description = "Forbes Latam named us one of the 20 most promising startups.",
                            Startup = "AI Farmers",
                            StartupId = new Guid("970188fd-1f01-4a25-9322-202abd5bcf54"),
                            Title = "Forbes LATAM Top 20 startups",
                            Type = 3
                        },
                        new
                        {
                            Id = new Guid("39094507-a62d-4a7c-8817-9c5969a34063"),
                            Date = new DateTime(2024, 3, 15, 4, 24, 20, 859, DateTimeKind.Local).AddTicks(5926),
                            Description = "We raised our 2 million Series A round",
                            Startup = "AI Farmers",
                            StartupId = new Guid("970188fd-1f01-4a25-9322-202abd5bcf54"),
                            Title = "Big series A",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("34bc5ade-df98-4b7d-b911-dabda2100092"),
                            Date = new DateTime(2024, 3, 21, 4, 24, 20, 859, DateTimeKind.Local).AddTicks(5943),
                            Description = "Our engineering team looks for promising colleagues.",
                            Startup = "AI Farmers",
                            StartupId = new Guid("970188fd-1f01-4a25-9322-202abd5bcf54"),
                            Title = "Open jobs in engineering",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("44c2dbfd-a70f-4e95-841b-094ec2660fff"),
                            Date = new DateTime(2023, 12, 13, 4, 24, 20, 859, DateTimeKind.Local).AddTicks(5960),
                            Description = "We are currently managing more then 100 square kilometres of farm land",
                            Startup = "AI Farmers",
                            StartupId = new Guid("970188fd-1f01-4a25-9322-202abd5bcf54"),
                            Title = "Managing more then 100 square kilometres of farm land",
                            Type = 3
                        },
                        new
                        {
                            Id = new Guid("b959bf9e-b980-416a-acf5-970dde68c74e"),
                            Date = new DateTime(2024, 2, 1, 4, 24, 20, 859, DateTimeKind.Local).AddTicks(5978),
                            Description = "We are developping are more resilient type of seeds together with our parterns",
                            Startup = "AI Farmers",
                            StartupId = new Guid("970188fd-1f01-4a25-9322-202abd5bcf54"),
                            Title = "Developing more resilient seed type",
                            Type = 2
                        },
                        new
                        {
                            Id = new Guid("ef3d8454-2b80-4251-b51b-63d4f2b2f161"),
                            Date = new DateTime(2024, 2, 12, 4, 24, 20, 859, DateTimeKind.Local).AddTicks(6077),
                            Description = "The 100rd restaurant uses our software",
                            Startup = "BiteAI",
                            StartupId = new Guid("7f03019b-cc87-4b20-87e1-9dce9c2ed9bc"),
                            Title = "100 customer",
                            Type = 3
                        },
                        new
                        {
                            Id = new Guid("bd61ceed-085c-4934-adeb-3de3ee0dc644"),
                            Date = new DateTime(2024, 2, 29, 4, 24, 20, 859, DateTimeKind.Local).AddTicks(6096),
                            Description = "With our AI we can help in saving emissions",
                            Startup = "BiteAI",
                            StartupId = new Guid("7f03019b-cc87-4b20-87e1-9dce9c2ed9bc"),
                            Title = "We minimize food waste with AI",
                            Type = 2
                        },
                        new
                        {
                            Id = new Guid("32f8bf30-9b1b-41c4-a39b-995456ac0b21"),
                            Date = new DateTime(2023, 8, 15, 4, 24, 20, 859, DateTimeKind.Local).AddTicks(6115),
                            Description = "We now operate with a Co-Ceo",
                            Startup = "BiteAI",
                            StartupId = new Guid("7f03019b-cc87-4b20-87e1-9dce9c2ed9bc"),
                            Title = "Starting with 2 Co-Ceos",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("1bc6a47a-133f-4877-bede-fce46cc78e10"),
                            Date = new DateTime(2023, 11, 23, 4, 24, 20, 859, DateTimeKind.Local).AddTicks(6133),
                            Description = "We are actively searching for new investors",
                            Startup = "BiteAI",
                            StartupId = new Guid("7f03019b-cc87-4b20-87e1-9dce9c2ed9bc"),
                            Title = "Searching for new investors",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("a71f30bf-06e0-4a99-be08-0190c407b8ca"),
                            Date = new DateTime(2024, 1, 15, 4, 24, 20, 859, DateTimeKind.Local).AddTicks(6183),
                            Description = "We are officially licensed for use in courts",
                            Startup = "BiteAI",
                            StartupId = new Guid("a362c026-adf5-4d71-a490-1887b45f784a"),
                            Title = "Licensed for use in courts",
                            Type = 3
                        },
                        new
                        {
                            Id = new Guid("9f7a2869-2e3d-4f01-8ebf-9a23d0cbaa65"),
                            Date = new DateTime(2024, 2, 27, 4, 24, 20, 859, DateTimeKind.Local).AddTicks(6200),
                            Description = "We are now partnering with charities",
                            Startup = "BiteAI",
                            StartupId = new Guid("a362c026-adf5-4d71-a490-1887b45f784a"),
                            Title = "Partnerin with charities",
                            Type = 2
                        },
                        new
                        {
                            Id = new Guid("b12d264b-2c5e-4df9-a554-34d51f571e0a"),
                            Date = new DateTime(2024, 2, 27, 4, 24, 20, 859, DateTimeKind.Local).AddTicks(6250),
                            Description = "We are enabling scientific breakthroughs",
                            Startup = "BiteAI",
                            StartupId = new Guid("fd621f64-1564-43f0-8e45-3a0662486708"),
                            Title = "Enabling scientific breakthroughs",
                            Type = 2
                        });
                });

            modelBuilder.Entity("Server.Features.Founders.Domain.Founder", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MobileEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("MobileNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Founders");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a1a0e845-993a-45d6-84d9-c9e9cb5c400d"),
                            Email = "test.founder@fellowship.com",
                            MobileEnabled = false,
                            MobileNumber = "45454556"
                        },
                        new
                        {
                            Id = new Guid("02211d91-2215-47b2-a39c-61abef1e7cf7"),
                            Email = "medtech@email.com",
                            MobileEnabled = false,
                            MobileNumber = "45454556"
                        },
                        new
                        {
                            Id = new Guid("1da64406-50e9-4f72-9cea-1c76fa30abca"),
                            Email = "aiFarmers@email.com",
                            MobileEnabled = false,
                            MobileNumber = "45454556"
                        },
                        new
                        {
                            Id = new Guid("c6671ed8-c63c-4e75-aa11-ea51468a97f2"),
                            Email = "aiRestaurant@email.com",
                            MobileEnabled = false,
                            MobileNumber = "45454556"
                        },
                        new
                        {
                            Id = new Guid("7f2de59f-79b1-4d2c-a9f1-b6fae6a6be82"),
                            Email = "legaltech@email.com",
                            MobileEnabled = false,
                            MobileNumber = "45454556"
                        },
                        new
                        {
                            Id = new Guid("69bb9ac9-1c93-416e-83f9-9eae84026cd5"),
                            Email = "fibers@email.com",
                            MobileEnabled = false,
                            MobileNumber = "45454556"
                        });
                });

            modelBuilder.Entity("Server.Features.Startups.Domain.StartUp", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Batch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discipline")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FounderEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("URI")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Startups");

                    b.HasData(
                        new
                        {
                            Id = new Guid("72576cab-5af9-4e22-9a96-1b2e5c4e2c56"),
                            Batch = "2024",
                            Description = "SaaS for cleaning companies",
                            Discipline = "SaaS",
                            FounderEmail = "test.founder@fellowship.com",
                            Location = "Brazil",
                            Name = "Cleantech",
                            URI = "www.cleantech.com"
                        },
                        new
                        {
                            Id = new Guid("3258411f-21ba-4d80-91b1-19225ce3b925"),
                            Batch = "2022",
                            Description = "Medtech for dentists",
                            Discipline = "Medtech",
                            FounderEmail = "medtech@email.com",
                            Location = "Ecuador",
                            Name = "MedDents",
                            URI = "www.medtech.com"
                        },
                        new
                        {
                            Id = new Guid("970188fd-1f01-4a25-9322-202abd5bcf54"),
                            Batch = "2023",
                            Description = "AI for the farming industry",
                            Discipline = "SaaS",
                            FounderEmail = "aiFarmers@email.com",
                            Location = "Argentina",
                            Name = "AI Farmers",
                            URI = "www.farmingwithai.com"
                        },
                        new
                        {
                            Id = new Guid("7f03019b-cc87-4b20-87e1-9dce9c2ed9bc"),
                            Batch = "2024",
                            Description = "Making restaurants more effective with AI",
                            Discipline = "SaaS",
                            FounderEmail = "aiRestaurant@email.com",
                            Location = "Argentina",
                            Name = "BiteAI",
                            URI = "www.biteai.com"
                        },
                        new
                        {
                            Id = new Guid("a362c026-adf5-4d71-a490-1887b45f784a"),
                            Batch = "2022",
                            Description = "Search engine for lawyers",
                            Discipline = "Legaltech",
                            FounderEmail = "legaltech@email.com",
                            Location = "Ecuador",
                            Name = "SearchLaw",
                            URI = "www.searchlaw.com"
                        },
                        new
                        {
                            Id = new Guid("fd621f64-1564-43f0-8e45-3a0662486708"),
                            Batch = "2022",
                            Description = "Microfibers for efficient materials",
                            Discipline = "Deeptech",
                            FounderEmail = "fibers@email.com",
                            Location = "Ecuador",
                            Name = "Fiberfficient",
                            URI = "www.fiberficcient.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
