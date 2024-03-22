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
    [Migration("20240322023800_startupContentId")]
    partial class startupContentId
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
                            Id = new Guid("e40e836a-83c7-45c2-9c69-6a827db2c96e"),
                            Date = new DateTime(2023, 12, 13, 3, 38, 0, 351, DateTimeKind.Local).AddTicks(6437),
                            Description = "New funding for the startup.",
                            Startup = "Cleantech",
                            StartupId = new Guid("327ab63f-e42c-4650-98e1-b4af7a8e9bed"),
                            Title = "Newly funded Startup",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("f37c6603-8fb5-48e3-b16f-ae519e862b6b"),
                            Date = new DateTime(2023, 9, 4, 3, 38, 0, 351, DateTimeKind.Local).AddTicks(6507),
                            Description = "The 1000 customer could be onboarded to the platform last week",
                            Startup = "Cleantech",
                            StartupId = new Guid("327ab63f-e42c-4650-98e1-b4af7a8e9bed"),
                            Title = "1000th customer",
                            Type = 3
                        },
                        new
                        {
                            Id = new Guid("c55dfdc6-3560-48e7-bd12-d2c9b4101a55"),
                            Date = new DateTime(2024, 2, 21, 3, 38, 0, 351, DateTimeKind.Local).AddTicks(6528),
                            Description = "We have 3 new openings in the marketing department",
                            Startup = "Cleantech",
                            StartupId = new Guid("327ab63f-e42c-4650-98e1-b4af7a8e9bed"),
                            Title = "Expanding marketing team",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("1cdd65d0-3ad9-4a29-a865-bff1a945cb2f"),
                            Date = new DateTime(2023, 12, 24, 3, 38, 0, 351, DateTimeKind.Local).AddTicks(6548),
                            Description = "From now on, we visit all our customers by train",
                            Startup = "Cleantech",
                            StartupId = new Guid("327ab63f-e42c-4650-98e1-b4af7a8e9bed"),
                            Title = "Taking the train for business tripps",
                            Type = 2
                        },
                        new
                        {
                            Id = new Guid("2bd291d4-5e85-47b9-b542-325f25f4bb7f"),
                            Date = new DateTime(2024, 1, 12, 3, 38, 0, 351, DateTimeKind.Local).AddTicks(6609),
                            Description = "We have 3 new openings in the finance department",
                            Startup = "MedDents",
                            StartupId = new Guid("e2804dfe-56fb-47a5-b57a-0d812ca6d465"),
                            Title = "Bigger finance team",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("883408e2-f703-405f-91c6-78b3b20f755b"),
                            Date = new DateTime(2023, 12, 3, 3, 38, 0, 351, DateTimeKind.Local).AddTicks(6682),
                            Description = "We have a new partner manager",
                            Startup = "MedDents",
                            StartupId = new Guid("e2804dfe-56fb-47a5-b57a-0d812ca6d465"),
                            Title = "Welcoming new faces",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("1af15345-0468-462c-b134-1d6231e83edb"),
                            Date = new DateTime(2024, 3, 19, 3, 38, 0, 351, DateTimeKind.Local).AddTicks(6703),
                            Description = "We could reduce our ecological footprint",
                            Startup = "Cleantech",
                            StartupId = new Guid("e2804dfe-56fb-47a5-b57a-0d812ca6d465"),
                            Title = "Succesfully reduced carbon footprint",
                            Type = 2
                        },
                        new
                        {
                            Id = new Guid("cc8d937b-7d14-4410-8ce6-5860a851c225"),
                            Date = new DateTime(2024, 2, 17, 3, 38, 0, 351, DateTimeKind.Local).AddTicks(6722),
                            Description = "After intense preparation we are now ISO certified",
                            Startup = "Cleantech",
                            StartupId = new Guid("e2804dfe-56fb-47a5-b57a-0d812ca6d465"),
                            Title = "ISO certification",
                            Type = 3
                        },
                        new
                        {
                            Id = new Guid("72c50517-3ba2-4212-9ad6-2002139e3881"),
                            Date = new DateTime(2022, 11, 16, 3, 38, 0, 351, DateTimeKind.Local).AddTicks(6740),
                            Description = "Successfully mitigated a hacker attack",
                            Startup = "Cleantech",
                            StartupId = new Guid("e2804dfe-56fb-47a5-b57a-0d812ca6d465"),
                            Title = "Prevented a hacker attack",
                            Type = 3
                        },
                        new
                        {
                            Id = new Guid("e438cb02-da27-4fd6-bbfe-aecb8883593f"),
                            Date = new DateTime(2023, 12, 21, 3, 38, 0, 351, DateTimeKind.Local).AddTicks(6759),
                            Description = "we are undergoing a reorganization",
                            Startup = "Cleantech",
                            StartupId = new Guid("e2804dfe-56fb-47a5-b57a-0d812ca6d465"),
                            Title = "Re-org to ensure competitivness",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("573a3ecd-fcd5-471d-80a2-99b48c933c6a"),
                            Date = new DateTime(2024, 2, 22, 3, 38, 0, 351, DateTimeKind.Local).AddTicks(6777),
                            Description = "we are saving emissons by working remote",
                            Startup = "Cleantech",
                            StartupId = new Guid("e2804dfe-56fb-47a5-b57a-0d812ca6d465"),
                            Title = "working remote saves emissions",
                            Type = 2
                        },
                        new
                        {
                            Id = new Guid("022d4dd2-9066-4474-bbf1-05dcbddcb455"),
                            Date = new DateTime(2024, 3, 13, 3, 38, 0, 351, DateTimeKind.Local).AddTicks(6798),
                            Description = "we are saving emissons by working remote",
                            Startup = "Cleantech",
                            StartupId = new Guid("e2804dfe-56fb-47a5-b57a-0d812ca6d465"),
                            Title = "working remote saves emissions",
                            Type = 2
                        },
                        new
                        {
                            Id = new Guid("f199dd78-1dde-4b2a-b6ba-77a47431d22c"),
                            Date = new DateTime(2024, 2, 10, 3, 38, 0, 351, DateTimeKind.Local).AddTicks(6846),
                            Description = "Forbes Latam named us one of the 20 most promising startups.",
                            Startup = "AI Farmers",
                            StartupId = new Guid("00000000-0000-0000-0000-000000000000"),
                            Title = "Forbes LATAM Top 20 startups",
                            Type = 3
                        },
                        new
                        {
                            Id = new Guid("4b44b605-0628-48d3-be41-9bf766be14ad"),
                            Date = new DateTime(2024, 3, 15, 3, 38, 0, 351, DateTimeKind.Local).AddTicks(6865),
                            Description = "We raised our 2 million Series A round",
                            Startup = "AI Farmers",
                            StartupId = new Guid("00000000-0000-0000-0000-000000000000"),
                            Title = "Big series A",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("566cb036-7a28-4632-a26f-6327e8885842"),
                            Date = new DateTime(2024, 3, 21, 3, 38, 0, 351, DateTimeKind.Local).AddTicks(6884),
                            Description = "Our engineering team looks for promising colleagues.",
                            Startup = "AI Farmers",
                            StartupId = new Guid("00000000-0000-0000-0000-000000000000"),
                            Title = "Open jobs in engineering",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("f206e895-d14d-4dab-9a73-9fbeb72ef9ce"),
                            Date = new DateTime(2024, 2, 12, 3, 38, 0, 351, DateTimeKind.Local).AddTicks(6936),
                            Description = "The 100rd restaurant uses our software",
                            Startup = "BiteAI",
                            StartupId = new Guid("00000000-0000-0000-0000-000000000000"),
                            Title = "100 customer",
                            Type = 3
                        },
                        new
                        {
                            Id = new Guid("ac511d92-4cc3-46fb-b08e-32236f4b76a9"),
                            Date = new DateTime(2024, 2, 29, 3, 38, 0, 351, DateTimeKind.Local).AddTicks(6956),
                            Description = "With our AI we can help in saving emissions",
                            Startup = "BiteAI",
                            StartupId = new Guid("00000000-0000-0000-0000-000000000000"),
                            Title = "We minimize food waste with AI",
                            Type = 2
                        },
                        new
                        {
                            Id = new Guid("40e1f91a-f105-4bf2-bcdb-fea11e640c2f"),
                            Date = new DateTime(2024, 1, 15, 3, 38, 0, 351, DateTimeKind.Local).AddTicks(7008),
                            Description = "We are officially licensed for use in courts",
                            Startup = "BiteAI",
                            StartupId = new Guid("00000000-0000-0000-0000-000000000000"),
                            Title = "Licensed for use in courts",
                            Type = 3
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
                            Id = new Guid("7c999d15-0ced-4f11-87fb-dbd2e9620e49"),
                            Email = "test.founder@fellowship.com",
                            MobileEnabled = false,
                            MobileNumber = "45454556"
                        },
                        new
                        {
                            Id = new Guid("c2584b35-3c07-45f3-aef8-dd885039a837"),
                            Email = "medtech@email.com",
                            MobileEnabled = false,
                            MobileNumber = "45454556"
                        },
                        new
                        {
                            Id = new Guid("da4c0289-4aca-4c7a-a204-ff46d5e11594"),
                            Email = "aiFarmers@email.com",
                            MobileEnabled = false,
                            MobileNumber = "45454556"
                        },
                        new
                        {
                            Id = new Guid("5a91f566-37db-4052-b09c-7e569555706a"),
                            Email = "aiRestaurant@email.com",
                            MobileEnabled = false,
                            MobileNumber = "45454556"
                        },
                        new
                        {
                            Id = new Guid("dc979906-992e-4412-abb8-cc542ab3a59f"),
                            Email = "legaltech@email.com",
                            MobileEnabled = false,
                            MobileNumber = "45454556"
                        },
                        new
                        {
                            Id = new Guid("3b95a5bb-d135-4dc9-9d48-76cde8876b75"),
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
                            Id = new Guid("327ab63f-e42c-4650-98e1-b4af7a8e9bed"),
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
                            Id = new Guid("e2804dfe-56fb-47a5-b57a-0d812ca6d465"),
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
                            Id = new Guid("5ed63ad0-e0fa-4754-bc06-21aecdc37edd"),
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
                            Id = new Guid("86cecd1d-dfb4-4220-a49b-2f8e31e4a03d"),
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
                            Id = new Guid("acfb429d-4ba6-4828-9841-a9a9e77b373f"),
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
                            Id = new Guid("7e1f9a1a-16c0-481c-9215-709d6c801298"),
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