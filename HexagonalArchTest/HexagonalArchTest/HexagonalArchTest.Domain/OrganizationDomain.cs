using HexagonalArchTest.DomainApi.Ports;
using HexagonalArchTest.Persistence.Adapter.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace HexagonalArchTest.Organization
{
    public class OrganizationDomain<T> : IRequestOrganization<T> where T : class
    {
        private readonly DbSet<T> table;

        public OrganizationDomain(ApplicationDbContext dbContext)
        {
            ApplicationDbContext _dbContext;
            _dbContext = dbContext;
            _dbContext.Database.EnsureCreated();
            table = _dbContext.Set<T>();
        }
        public T GetOrganization(int id)
        {
            return table.Find(id);
        }

        public List<T> GetOrganizations()
        {
            return table.ToList();
        }
    }
}
