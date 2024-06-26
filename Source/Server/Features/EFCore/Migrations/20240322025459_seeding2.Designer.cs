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
    [Migration("20240322025459_seeding2")]
    partial class seeding2
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
                            Id = new Guid("c6d41f94-ac4b-4876-aa82-1674020e9830"),
                            Date = new DateTime(2023, 12, 13, 3, 54, 59, 242, DateTimeKind.Local).AddTicks(3949),
                            Description = "New funding for the startup.",
                            Startup = "Cleantech",
                            StartupId = new Guid("e584d879-299a-48ad-921c-308e70a37e7a"),
                            Title = "Newly funded Startup",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("07ff0f8b-f795-40f2-a853-174a0c7981db"),
                            Date = new DateTime(2023, 9, 4, 3, 54, 59, 242, DateTimeKind.Local).AddTicks(4058),
                            Description = "The 1000 customer could be onboarded to the platform last week",
                            Startup = "Cleantech",
                            StartupId = new Guid("e584d879-299a-48ad-921c-308e70a37e7a"),
                            Title = "1000th customer",
                            Type = 3
                        },
                        new
                        {
                            Id = new Guid("2ed84318-10a3-464d-85cd-0755fe86bcaa"),
                            Date = new DateTime(2024, 2, 21, 3, 54, 59, 242, DateTimeKind.Local).AddTicks(4081),
                            Description = "We have 3 new openings in the marketing department",
                            Startup = "Cleantech",
                            StartupId = new Guid("e584d879-299a-48ad-921c-308e70a37e7a"),
                            Title = "Expanding marketing team",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("7340c653-cdc0-427b-a14b-ad4e4bf56e16"),
                            Date = new DateTime(2023, 12, 24, 3, 54, 59, 242, DateTimeKind.Local).AddTicks(4115),
                            Description = "From now on, we visit all our customers by train",
                            Startup = "Cleantech",
                            StartupId = new Guid("e584d879-299a-48ad-921c-308e70a37e7a"),
                            Title = "Taking the train for business tripps",
                            Type = 2
                        },
                        new
                        {
                            Id = new Guid("d823e045-c991-48e0-afe0-9c7971a234a5"),
                            Date = new DateTime(2024, 1, 12, 3, 54, 59, 242, DateTimeKind.Local).AddTicks(4167),
                            Description = "We have 3 new openings in the finance department",
                            Startup = "MedDents",
                            StartupId = new Guid("22c22178-7d76-4ddc-94ba-6e773de6f9a1"),
                            Title = "Bigger finance team",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("bc9f95c0-1b2f-4366-be0e-c9f21982cc98"),
                            Date = new DateTime(2023, 12, 3, 3, 54, 59, 242, DateTimeKind.Local).AddTicks(4190),
                            Description = "We have a new partner manager",
                            Startup = "MedDents",
                            StartupId = new Guid("22c22178-7d76-4ddc-94ba-6e773de6f9a1"),
                            Title = "Welcoming new faces",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("bd45aaa2-6c4a-43ab-a0e2-28754e438d8a"),
                            Date = new DateTime(2024, 3, 19, 3, 54, 59, 242, DateTimeKind.Local).AddTicks(4210),
                            Description = "We could reduce our ecological footprint",
                            Startup = "Cleantech",
                            StartupId = new Guid("e584d879-299a-48ad-921c-308e70a37e7a"),
                            Title = "Succesfully reduced carbon footprint",
                            Type = 2
                        },
                        new
                        {
                            Id = new Guid("1ac6c282-e0a6-4b21-9684-4a52d18df113"),
                            Date = new DateTime(2024, 2, 17, 3, 54, 59, 242, DateTimeKind.Local).AddTicks(4228),
                            Description = "After intense preparation we are now ISO certified",
                            Startup = "Cleantech",
                            StartupId = new Guid("e584d879-299a-48ad-921c-308e70a37e7a"),
                            Title = "ISO certification",
                            Type = 3
                        },
                        new
                        {
                            Id = new Guid("65a8ba59-43b3-4497-b0b1-0854284f7ecc"),
                            Date = new DateTime(2022, 11, 16, 3, 54, 59, 242, DateTimeKind.Local).AddTicks(4248),
                            Description = "Successfully mitigated a hacker attack",
                            Startup = "Cleantech",
                            StartupId = new Guid("e584d879-299a-48ad-921c-308e70a37e7a"),
                            Title = "Prevented a hacker attack",
                            Type = 3
                        },
                        new
                        {
                            Id = new Guid("f434d8c2-29f1-47bc-b749-2f20870709d8"),
                            Date = new DateTime(2023, 12, 21, 3, 54, 59, 242, DateTimeKind.Local).AddTicks(4271),
                            Description = "we are undergoing a reorganization",
                            Startup = "Cleantech",
                            StartupId = new Guid("e584d879-299a-48ad-921c-308e70a37e7a"),
                            Title = "Re-org to ensure competitivness",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("1b8f3d0c-4245-4939-bdb6-da602a67ba15"),
                            Date = new DateTime(2024, 2, 22, 3, 54, 59, 242, DateTimeKind.Local).AddTicks(4291),
                            Description = "we are saving emissons by working remote",
                            Startup = "Cleantech",
                            StartupId = new Guid("e584d879-299a-48ad-921c-308e70a37e7a"),
                            Title = "working remote saves emissions",
                            Type = 2
                        },
                        new
                        {
                            Id = new Guid("96bda7b5-d9d2-4a63-919e-5152dec552ce"),
                            Date = new DateTime(2024, 3, 13, 3, 54, 59, 242, DateTimeKind.Local).AddTicks(4311),
                            Description = "we are saving emissons by working remote",
                            Startup = "Cleantech",
                            StartupId = new Guid("e584d879-299a-48ad-921c-308e70a37e7a"),
                            Title = "working remote saves emissions",
                            Type = 2
                        },
                        new
                        {
                            Id = new Guid("317f60fc-a5ea-43d6-9c7f-4757c8d3f50e"),
                            Date = new DateTime(2024, 2, 10, 3, 54, 59, 242, DateTimeKind.Local).AddTicks(4361),
                            Description = "Forbes Latam named us one of the 20 most promising startups.",
                            Startup = "AI Farmers",
                            StartupId = new Guid("4106d7a6-81f9-4ecf-8041-73671a4831f2"),
                            Title = "Forbes LATAM Top 20 startups",
                            Type = 3
                        },
                        new
                        {
                            Id = new Guid("6944c512-1ea2-424b-9f10-d45cdbaac1b7"),
                            Date = new DateTime(2024, 3, 15, 3, 54, 59, 242, DateTimeKind.Local).AddTicks(4379),
                            Description = "We raised our 2 million Series A round",
                            Startup = "AI Farmers",
                            StartupId = new Guid("4106d7a6-81f9-4ecf-8041-73671a4831f2"),
                            Title = "Big series A",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("2648411b-1372-49c4-8155-3ac24ca49657"),
                            Date = new DateTime(2024, 3, 21, 3, 54, 59, 242, DateTimeKind.Local).AddTicks(4398),
                            Description = "Our engineering team looks for promising colleagues.",
                            Startup = "AI Farmers",
                            StartupId = new Guid("4106d7a6-81f9-4ecf-8041-73671a4831f2"),
                            Title = "Open jobs in engineering",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("4e236406-7294-465c-b87f-f4077158ac48"),
                            Date = new DateTime(2023, 12, 13, 3, 54, 59, 242, DateTimeKind.Local).AddTicks(4419),
                            Description = "We are currently managing more then 100 square kilometres of farm land",
                            Startup = "AI Farmers",
                            StartupId = new Guid("4106d7a6-81f9-4ecf-8041-73671a4831f2"),
                            Title = "Managing more then 100 square kilometres of farm land",
                            Type = 3
                        },
                        new
                        {
                            Id = new Guid("8519a75f-c327-4451-bca0-2e2c658c838c"),
                            Date = new DateTime(2024, 2, 1, 3, 54, 59, 242, DateTimeKind.Local).AddTicks(4439),
                            Description = "We are developping are more resilient type of seeds together with our parterns",
                            Startup = "AI Farmers",
                            StartupId = new Guid("4106d7a6-81f9-4ecf-8041-73671a4831f2"),
                            Title = "Developing more resilient seed type",
                            Type = 2
                        },
                        new
                        {
                            Id = new Guid("8066dde0-b35d-40be-b5a7-df9854a6142e"),
                            Date = new DateTime(2024, 2, 12, 3, 54, 59, 242, DateTimeKind.Local).AddTicks(4489),
                            Description = "The 100rd restaurant uses our software",
                            Startup = "BiteAI",
                            StartupId = new Guid("35572f3b-baba-485b-b540-1aca8540d984"),
                            Title = "100 customer",
                            Type = 3
                        },
                        new
                        {
                            Id = new Guid("93f41e33-75aa-4cd3-bf5b-dbaa603c51f3"),
                            Date = new DateTime(2024, 2, 29, 3, 54, 59, 242, DateTimeKind.Local).AddTicks(4509),
                            Description = "With our AI we can help in saving emissions",
                            Startup = "BiteAI",
                            StartupId = new Guid("35572f3b-baba-485b-b540-1aca8540d984"),
                            Title = "We minimize food waste with AI",
                            Type = 2
                        },
                        new
                        {
                            Id = new Guid("68a41238-1e87-4c34-a080-c8541319de6b"),
                            Date = new DateTime(2023, 8, 15, 3, 54, 59, 242, DateTimeKind.Local).AddTicks(4565),
                            Description = "We now operate with a Co-Ceo",
                            Startup = "BiteAI",
                            StartupId = new Guid("35572f3b-baba-485b-b540-1aca8540d984"),
                            Title = "Starting with 2 Co-Ceos",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("7b6ecbf2-220a-4198-a8a5-1ae573981d01"),
                            Date = new DateTime(2023, 11, 23, 3, 54, 59, 242, DateTimeKind.Local).AddTicks(4586),
                            Description = "We are actively searching for new investors",
                            Startup = "BiteAI",
                            StartupId = new Guid("35572f3b-baba-485b-b540-1aca8540d984"),
                            Title = "Searching for new investors",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("25d5f9a0-f152-4a7d-a27d-0fdaefcd5e8b"),
                            Date = new DateTime(2024, 1, 15, 3, 54, 59, 242, DateTimeKind.Local).AddTicks(4640),
                            Description = "We are officially licensed for use in courts",
                            Startup = "BiteAI",
                            StartupId = new Guid("966abdbd-af82-4763-8e8f-6b42d935f99c"),
                            Title = "Licensed for use in courts",
                            Type = 3
                        },
                        new
                        {
                            Id = new Guid("932abc40-e590-4abb-a58b-336eeb8f1645"),
                            Date = new DateTime(2024, 2, 27, 3, 54, 59, 242, DateTimeKind.Local).AddTicks(4659),
                            Description = "We are now partnering with charities",
                            Startup = "BiteAI",
                            StartupId = new Guid("966abdbd-af82-4763-8e8f-6b42d935f99c"),
                            Title = "Partnerin with charities",
                            Type = 2
                        },
                        new
                        {
                            Id = new Guid("21b6fa02-3b44-42f6-8391-033ba7e2272a"),
                            Date = new DateTime(2024, 2, 27, 3, 54, 59, 242, DateTimeKind.Local).AddTicks(4707),
                            Description = "We are enabling scientific breakthroughs",
                            Startup = "BiteAI",
                            StartupId = new Guid("d5ab19ef-1208-4b7c-9b41-bdb796eaab21"),
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
                            Id = new Guid("bfbfc654-8ead-482b-858b-b65ffcd87717"),
                            Email = "test.founder@fellowship.com",
                            MobileEnabled = false,
                            MobileNumber = "45454556"
                        },
                        new
                        {
                            Id = new Guid("d21bc5d0-ee5d-4bcb-8e8f-a544d6154306"),
                            Email = "medtech@email.com",
                            MobileEnabled = false,
                            MobileNumber = "45454556"
                        },
                        new
                        {
                            Id = new Guid("763be86f-f860-4aca-bb23-ee08decd7c38"),
                            Email = "aiFarmers@email.com",
                            MobileEnabled = false,
                            MobileNumber = "45454556"
                        },
                        new
                        {
                            Id = new Guid("bf002121-61aa-4cc9-8d9f-cd25eea58227"),
                            Email = "aiRestaurant@email.com",
                            MobileEnabled = false,
                            MobileNumber = "45454556"
                        },
                        new
                        {
                            Id = new Guid("7e5c59f5-f904-481b-a7f3-3ce20d8b5557"),
                            Email = "legaltech@email.com",
                            MobileEnabled = false,
                            MobileNumber = "45454556"
                        },
                        new
                        {
                            Id = new Guid("ee6ea0ae-65fd-4886-b5b8-5a02cd8455e9"),
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
                            Id = new Guid("e584d879-299a-48ad-921c-308e70a37e7a"),
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
                            Id = new Guid("22c22178-7d76-4ddc-94ba-6e773de6f9a1"),
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
                            Id = new Guid("4106d7a6-81f9-4ecf-8041-73671a4831f2"),
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
                            Id = new Guid("35572f3b-baba-485b-b540-1aca8540d984"),
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
                            Id = new Guid("966abdbd-af82-4763-8e8f-6b42d935f99c"),
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
                            Id = new Guid("d5ab19ef-1208-4b7c-9b41-bdb796eaab21"),
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
