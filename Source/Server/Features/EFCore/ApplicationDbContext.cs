using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Server.Features.ContentFeed;
using Server.Features.Founders.Domain;
using Server.Features.Startups.Domain;
using System;

namespace Server.Features.EFCore
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<StartUp> Startups { get; set; }
        public DbSet<Founder> Founders { get; set; }
        public DbSet<StartupContent> StartupContents { get; set; }
        public DbSet<CrawledContent> CrawledContents { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            var cleantechStartupId = System.Guid.NewGuid();

            builder.Entity<StartUp>()
                .HasData(new StartUp
                {
                    Location = "Brazil",
                    Description = "SaaS for cleaning companies",
                    Discipline = "SaaS",
                    Batch = "2024",
                    FounderEmail = "test.founder@fellowship.com",
                    Name = "Cleantech",
                    URI = "www.cleantech.com",
                    Id = cleantechStartupId
                });

            builder.Entity<Founder>()
                .HasData(new Founder
                {
                    Email = "test.founder@fellowship.com",
                    MobileNumber = "45454556",
                    Id = System.Guid.NewGuid()
                });

            builder.Entity<StartupContent>()
                .HasData(new StartupContent
                {
                    Date = DateTime.Now.AddDays(-100),
                    Description = "New funding for the startup.",
                    Startup = "Cleantech",
                    Type = Shared.ContentFeed.NewsType.Funding,
                    Id = System.Guid.NewGuid(),
                    Title = "Newly funded Startup",
                    StartupId = cleantechStartupId
                });

            builder.Entity<StartupContent>()
                .HasData(new StartupContent
                {
                    Date = DateTime.Now.AddDays(-200),
                    Description = "The 1000 customer could be onboarded to the platform last week",
                    Startup = "Cleantech",
                    Type = Shared.ContentFeed.NewsType.Achievement,
                    Id = System.Guid.NewGuid(),
                    Title = "1000th customer",
                    StartupId = cleantechStartupId
                });

            builder.Entity<StartupContent>()
                .HasData(new StartupContent
                {
                    Date = DateTime.Now.AddDays(-30),
                    Description = "We have 3 new openings in the marketing department",
                    Startup = "Cleantech",
                    Type = Shared.ContentFeed.NewsType.Team,
                    Id = System.Guid.NewGuid(),
                    Title = "Expanding marketing team",
                    StartupId = cleantechStartupId
                });

            builder.Entity<StartupContent>()
                .HasData(new StartupContent
                {
                    Date = DateTime.Now.AddDays(-89),
                    Description = "From now on, we visit all our customers by train",
                    Startup = "Cleantech",
                    Type = Shared.ContentFeed.NewsType.ESG,
                    Id = System.Guid.NewGuid(),
                    Title = "Taking the train for business tripps",
                    StartupId = cleantechStartupId
                });

            var medDentsId = Guid.NewGuid();

            builder.Entity<StartUp>()
                .HasData(new StartUp
                {
                    Location = "Ecuador",
                    Description = "Medtech for dentists",
                    Discipline = "Medtech",
                    Batch = "2022",
                    FounderEmail = "medtech@email.com",
                    Name = "MedDents",
                    URI = "www.medtech.com",
                    Id = medDentsId
                });

            builder.Entity<Founder>()
                .HasData(new Founder
                {
                    Email = "medtech@email.com",
                    MobileNumber = "45454556",
                    Id = System.Guid.NewGuid()
                });

            builder.Entity<StartupContent>()
                .HasData(new StartupContent
                {
                    Date = DateTime.Now.AddDays(-70),
                    Description = "We have 3 new openings in the finance department",
                    Startup = "MedDents",
                    Type = Shared.ContentFeed.NewsType.Team,
                    Id = System.Guid.NewGuid(),
                    Title = "Bigger finance team",
                    StartupId = medDentsId
                });

            builder.Entity<StartupContent>()
                .HasData(new StartupContent
                {
                    Date = DateTime.Now.AddDays(-110),
                    Description = "We have a new partner manager",
                    Startup = "MedDents",
                    Type = Shared.ContentFeed.NewsType.Team,
                    Id = System.Guid.NewGuid(),
                    Title = "Welcoming new faces",
                    StartupId = medDentsId
                });



            builder.Entity<StartupContent>()
                .HasData(new StartupContent
                {
                    Date = DateTime.Now.AddDays(-3),
                    Description = "We could reduce our ecological footprint",
                    Startup = "Cleantech",
                    Type = Shared.ContentFeed.NewsType.ESG,
                    Id = System.Guid.NewGuid(),
                    Title = "Succesfully reduced carbon footprint",
                    StartupId = cleantechStartupId
                });

            builder.Entity<StartupContent>()
                .HasData(new StartupContent
                {
                    Date = DateTime.Now.AddDays(-34),
                    Description = "After intense preparation we are now ISO certified",
                    Startup = "Cleantech",
                    Type = Shared.ContentFeed.NewsType.Achievement,
                    Id = System.Guid.NewGuid(),
                    Title = "ISO certification",
                    StartupId = cleantechStartupId
                });

            builder.Entity<StartupContent>()
                .HasData(new StartupContent
                {
                    Date = DateTime.Now.AddDays(-492),
                    Description = "Successfully mitigated a hacker attack",
                    Startup = "Cleantech",
                    Type = Shared.ContentFeed.NewsType.Achievement,
                    Id = System.Guid.NewGuid(),
                    Title = "Prevented a hacker attack",
                    StartupId = cleantechStartupId
                });

            builder.Entity<StartupContent>()
                .HasData(new StartupContent
                {
                    Date = DateTime.Now.AddDays(-92),
                    Description = "we are undergoing a reorganization",
                    Startup = "Cleantech",
                    Type = Shared.ContentFeed.NewsType.Team,
                    Id = System.Guid.NewGuid(),
                    Title = "Re-org to ensure competitivness",
                    StartupId = cleantechStartupId
                });

            builder.Entity<StartupContent>()
                .HasData(new StartupContent
                {
                    Date = DateTime.Now.AddDays(-29),
                    Description = "we are saving emissons by working remote",
                    Startup = "Cleantech",
                    Type = Shared.ContentFeed.NewsType.ESG,
                    Id = System.Guid.NewGuid(),
                    Title = "working remote saves emissions",
                    StartupId = cleantechStartupId
                });

            builder.Entity<StartupContent>()
               .HasData(new StartupContent
               {
                   Date = DateTime.Now.AddDays(-9),
                   Description = "we are saving emissons by working remote",
                   Startup = "Cleantech",
                   Type = Shared.ContentFeed.NewsType.ESG,
                   Id = System.Guid.NewGuid(),
                   Title = "working remote saves emissions",
                   StartupId = cleantechStartupId
               });

            var aiFarmersId = Guid.NewGuid();

            builder.Entity<StartUp>()
                .HasData(new StartUp
                {
                    Location = "Argentina",
                    Description = "AI for the farming industry",
                    Discipline = "SaaS",
                    Batch = "2023",
                    FounderEmail = "aiFarmers@email.com",
                    Name = "AI Farmers",
                    URI = "www.farmingwithai.com",
                    Id = aiFarmersId,
                });

            builder.Entity<Founder>()
                .HasData(new Founder
                {
                    Email = "aiFarmers@email.com",
                    MobileNumber = "45454556",
                    Id = System.Guid.NewGuid()
                });

            builder.Entity<StartupContent>()
                .HasData(new StartupContent
                {
                    Date = DateTime.Now.AddDays(-41),
                    Description = "Forbes Latam named us one of the 20 most promising startups.",
                    Startup = "AI Farmers",
                    Type = Shared.ContentFeed.NewsType.Achievement,
                    Id = System.Guid.NewGuid(),
                    Title = "Forbes LATAM Top 20 startups",
                    StartupId = aiFarmersId,
                });

            builder.Entity<StartupContent>()
                .HasData(new StartupContent
                {
                    Date = DateTime.Now.AddDays(-7),
                    Description = "We raised our 2 million Series A round",
                    Startup = "AI Farmers",
                    Type = Shared.ContentFeed.NewsType.Funding,
                    Id = System.Guid.NewGuid(),
                    Title = "Big series A",
                    StartupId = aiFarmersId
                });

            builder.Entity<StartupContent>()
                .HasData(new StartupContent
                {
                    Date = DateTime.Now.AddDays(-1),
                    Description = "Our engineering team looks for promising colleagues.",
                    Startup = "AI Farmers",
                    Type = Shared.ContentFeed.NewsType.Team,
                    Id = System.Guid.NewGuid(),
                    Title = "Open jobs in engineering",
                    StartupId = aiFarmersId
                });

            builder.Entity<StartupContent>()
                .HasData(new StartupContent
                {
                    Date = DateTime.Now.AddDays(-100),
                    Description = "We are currently managing more then 100 square kilometres of farm land",
                    Startup = "AI Farmers",
                    Type = Shared.ContentFeed.NewsType.Achievement,
                    Id = System.Guid.NewGuid(),
                    Title = "Managing more then 100 square kilometres of farm land",
                    StartupId = aiFarmersId
                });

            builder.Entity<StartupContent>()
               .HasData(new StartupContent
               {
                   Date = DateTime.Now.AddDays(-50),
                   Description = "We are developping are more resilient type of seeds together with our parterns",
                   Startup = "AI Farmers",
                   Type = Shared.ContentFeed.NewsType.ESG,
                   Id = System.Guid.NewGuid(),
                   Title = "Developing more resilient seed type",
                   StartupId = aiFarmersId
               });

            var biteAiId = Guid.NewGuid();

            builder.Entity<StartUp>()
                .HasData(new StartUp
                {
                    Location = "Argentina",
                    Description = "Making restaurants more effective with AI",
                    Discipline = "SaaS",
                    Batch = "2024",
                    FounderEmail = "aiRestaurant@email.com",
                    Name = "BiteAI",
                    URI = "www.biteai.com",
                    Id = biteAiId
                });

            builder.Entity<Founder>()
                .HasData(new Founder
                {
                    Email = "aiRestaurant@email.com",
                    MobileNumber = "45454556",
                    Id = System.Guid.NewGuid()
                });

            builder.Entity<StartupContent>()
                .HasData(new StartupContent
                {
                    Date = DateTime.Now.AddDays(-39),
                    Description = "The 100rd restaurant uses our software",
                    Startup = "BiteAI",
                    Type = Shared.ContentFeed.NewsType.Achievement,
                    Id = System.Guid.NewGuid(),
                    Title = "100 customer",
                    StartupId = biteAiId
                });

            builder.Entity<StartupContent>()
                .HasData(new StartupContent
                {
                    Date = DateTime.Now.AddDays(-22),
                    Description = "With our AI we can help in saving emissions",
                    Startup = "BiteAI",
                    Type = Shared.ContentFeed.NewsType.ESG,
                    Id = System.Guid.NewGuid(),
                    Title = "We minimize food waste with AI",
                    StartupId = biteAiId
                });

            builder.Entity<StartupContent>()
                .HasData(new StartupContent
                {
                    Date = DateTime.Now.AddDays(-220),
                    Description = "We now operate with a Co-Ceo",
                    Startup = "BiteAI",
                    Type = Shared.ContentFeed.NewsType.Team,
                    Id = System.Guid.NewGuid(),
                    Title = "Starting with 2 Co-Ceos",
                    StartupId = biteAiId
                });

            builder.Entity<StartupContent>()
                .HasData(new StartupContent
                {
                    Date = DateTime.Now.AddDays(-120),
                    Description = "We are actively searching for new investors",
                    Startup = "BiteAI",
                    Type = Shared.ContentFeed.NewsType.Funding,
                    Id = System.Guid.NewGuid(),
                    Title = "Searching for new investors",
                    StartupId = biteAiId
                });

            var searchLawId = Guid.NewGuid();

            builder.Entity<StartUp>()
                .HasData(new StartUp
                {
                    Location = "Ecuador",
                    Description = "Search engine for lawyers",
                    Discipline = "Legaltech",
                    Batch = "2022",
                    FounderEmail = "legaltech@email.com",
                    Name = "SearchLaw",
                    URI = "www.searchlaw.com",
                    Id = searchLawId,

                });

            builder.Entity<Founder>()
                .HasData(new Founder
                {
                    Email = "legaltech@email.com",
                    MobileNumber = "45454556",
                    Id = System.Guid.NewGuid()
                });

            builder.Entity<StartupContent>()
                .HasData(new StartupContent
                {
                    Date = DateTime.Now.AddDays(-67),
                    Description = "We are officially licensed for use in courts",
                    Startup = "BiteAI",
                    Type = Shared.ContentFeed.NewsType.Achievement,
                    Id = System.Guid.NewGuid(),
                    Title = "Licensed for use in courts",
                    StartupId = searchLawId
                });

            builder.Entity<StartupContent>()
               .HasData(new StartupContent
               {
                   Date = DateTime.Now.AddDays(-24),
                   Description = "We are now partnering with charities",
                   Startup = "BiteAI",
                   Type = Shared.ContentFeed.NewsType.ESG,
                   Id = System.Guid.NewGuid(),
                   Title = "Partnerin with charities",
                   StartupId = searchLawId
               });

            var guidFibreIds = Guid.NewGuid();

            builder.Entity<StartUp>()
                .HasData(new StartUp
                {
                    Location = "Ecuador",
                    Description = "Microfibers for efficient materials",
                    Discipline = "Deeptech",
                    Batch = "2022",
                    FounderEmail = "fibers@email.com",
                    Name = "Fiberfficient",
                    URI = "www.fiberficcient.com",
                    Id = guidFibreIds
                });

            builder.Entity<Founder>()
                .HasData(new Founder
                {
                    Email = "fibers@email.com",
                    MobileNumber = "45454556",
                    Id = System.Guid.NewGuid()
                });

            builder.Entity<StartupContent>()
               .HasData(new StartupContent
               {
                   Date = DateTime.Now.AddDays(-24),
                   Description = "We are enabling scientific breakthroughs",
                   Startup = "BiteAI",
                   Type = Shared.ContentFeed.NewsType.ESG,
                   Id = System.Guid.NewGuid(),
                   Title = "Enabling scientific breakthroughs",
                   StartupId = guidFibreIds
               });

            base.OnModelCreating(builder);
        }
    }
}

