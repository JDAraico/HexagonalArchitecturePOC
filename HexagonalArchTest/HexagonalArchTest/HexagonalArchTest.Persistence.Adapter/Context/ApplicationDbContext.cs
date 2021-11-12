using HexagonalArchTest.DomainApi.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace HexagonalArchTest.Persistence.Adapter.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Organization> Organizations { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var organizations = new Organization[] {
                new Organization { Id = 1, Name = "Org1", State = "State1", NCESID = 181, UID = 1 },
                new Organization { Id = 2, Name = "Org2", State = "State2", NCESID = 118, UID = 2 },
                new Organization { Id = 3, Name = "Org3", State = "State3", NCESID = 105, UID = 3 },
                new Organization { Id = 4, Name = "Org4", State = "State4", NCESID = 116, UID = 4 },
                new Organization { Id = 5, Name = "Org5", State = "State5", NCESID = 120, UID = 5 }
            };
            modelBuilder.Entity<Organization>().HasKey(p => new { p.Id });
            modelBuilder.Entity<Organization>().HasData(organizations);
            base.OnModelCreating(modelBuilder);
        }
    }
}
