using HexagonalArchTest.DomainApi.Model;
using HexagonalArchTest.Persistence.Adapter.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace HexagonalArchTest.Persistence.Adapter.UnitTest.Common
{
    public static class ApplicationDbContextFactory
    {
        public static List<Organization> GetOrganizations()
        {
            return new List<Organization>()
            {
                new Organization(){Id=1, Name="ABC", NCESID=123},
                new Organization(){Id=2, Name="CDF", NCESID=456},
                new Organization(){Id=3, Name="GHI", NCESID=789},
            };
        }

        public static ApplicationDbContext Create()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            var context = new ApplicationDbContext(options);
            context.Database.EnsureCreated();
            context.Organizations.AddRange(GetOrganizations());
            context.SaveChanges();
            return context;
        }
        public static void Destroy(ApplicationDbContext dbContext)
        {
            dbContext.Database.EnsureDeleted();
            dbContext.Dispose();
        }
    }
}
