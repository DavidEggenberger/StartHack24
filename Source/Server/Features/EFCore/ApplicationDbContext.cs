using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Server.Features.Founders.Domain;
using Server.Features.Startups.Domain;

namespace Server.Features.EFCore
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<StartUp> Startups { get; set; }
        public DbSet<Founder> Founders { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
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
                    Id = System.Guid.NewGuid()
                });

            base.OnModelCreating(builder);
        }
    }
}
