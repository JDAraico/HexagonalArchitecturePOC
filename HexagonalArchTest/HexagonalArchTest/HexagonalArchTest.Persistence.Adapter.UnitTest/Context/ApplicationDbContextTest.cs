using HexagonalArchTest.DomainApi.Model;
using HexagonalArchTest.Persistence.Adapter.UnitTest.Common;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System.Threading.Tasks;

namespace HexagonalArchTest.Persistence.Adapter.UnitTest.Context
{
    public class ApplicationDbContextTest
    {
        [Test]
        public void CanInsertOrganizationIntoDatabase()
        {
            using var context = ApplicationDbContextFactory.Create();
            var Organization = new Organization();
            context.Organizations.Add(Organization);
            Assert.AreEqual(EntityState.Added, context.Entry(Organization).State);

            var result = context.SaveChangesAsync();
            Assert.AreEqual(1, result.Result);
            Assert.AreEqual(Task.CompletedTask.Status, result.Status);
            Assert.AreEqual(EntityState.Unchanged, context.Entry(Organization).State);

        }

        [Test]
        public void CanDeleteDealIntoDatabase()
        {
            using var context = ApplicationDbContextFactory.Create();
            var Organization = new Organization();
            context.Organizations.Remove(Organization);
            Assert.AreEqual(EntityState.Deleted, context.Entry(Organization).State);
        }
    }
}
