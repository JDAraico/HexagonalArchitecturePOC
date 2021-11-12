using HexagonalArchTest.DomainApi.Model;
using HexagonalArchTest.Organization;
using HexagonalArchTest.Persistence.Adapter.UnitTest.Common;
using NUnit.Framework;

namespace HexagonalArchTest.Domain.UnitTest
{
    public class DealDomainTest
    {
        private OrganizationDomain<DomainApi.Model.Organization> _organizationDomain;

        [Test]
        public void GetDealsTest()
        {
            using var context = ApplicationDbContextFactory.Create();
            _organizationDomain = new OrganizationDomain<DomainApi.Model.Organization>(context);
            var deals = _organizationDomain.GetOrganizations();
            Assert.AreEqual(3, deals.Count);
            Assert.AreEqual(1, deals[0].Id);
            Assert.AreEqual("ABC", deals[0].Name);
            Assert.AreEqual(45123, deals[0].NCESID);

        }

        [Test]
        public void GetDealByIdTest()
        {
            using var context = ApplicationDbContextFactory.Create();
            _organizationDomain = new OrganizationDomain<DomainApi.Model.Organization>(context);
            var deals = _organizationDomain.GetOrganization(1);
            Assert.AreEqual(1, deals.Id);
            Assert.AreEqual("ABC", deals.Name);
            Assert.AreEqual(45123, deals.NCESID);

        }
    }
}