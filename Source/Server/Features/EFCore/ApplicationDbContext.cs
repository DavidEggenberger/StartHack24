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
    }
}
