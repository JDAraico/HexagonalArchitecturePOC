using HexagonalArchTest.DomainApi.Model;
using NUnit.Framework;
using System.Collections.Generic;

namespace HexagonalArchTest.DomainApi.UnitTest.Model
{
    public class OrganizationInfoTest
    {
        private readonly OrganizationInfo _organizationInfo;

        public OrganizationInfoTest()
        {
            _organizationInfo = new OrganizationInfo();
        }

        [Test]
        public void TestSetAndGetName()
        {
            _organizationInfo.Organizations = GetOrganizations();
            Assert.IsTrue(_organizationInfo.Organizations.Count > 0);
        }

        private List<Organization> GetOrganizations()
        {
            return
                new List<Organization> { new Organization { NCESID = 1234586, Name = "Test Org" } };
        }
    }
}
