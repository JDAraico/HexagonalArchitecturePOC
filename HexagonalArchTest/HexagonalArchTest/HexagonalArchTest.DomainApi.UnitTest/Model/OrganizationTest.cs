using HexagonalArchTest.DomainApi.Model;
using NUnit.Framework;

namespace HexagonalArchTest.DomainApi.UnitTest.Model
{
    public class OrganizationTest
    {
        private readonly Organization _organization;
        private const string Name = "Test Organization name";
        private const int NCESID = 123456;

        public OrganizationTest()
        {
            _organization = new Organization();
        }

        [Test]
        public void TestSetAndGetName()
        {
            _organization.Name = Name;
            Assert.AreEqual(Name, _organization.Name);
        }

        [Test]
        public void TestSetAndGetNCESID()
        {
            _organization.NCESID = NCESID;
            Assert.AreEqual(NCESID, _organization.NCESID);
        }
    }
}
