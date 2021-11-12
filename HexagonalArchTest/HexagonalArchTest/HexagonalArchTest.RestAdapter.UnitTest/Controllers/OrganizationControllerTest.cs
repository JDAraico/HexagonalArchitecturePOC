using HexagonalArchTest.DomainApi.Model;
using HexagonalArchTest.DomainApi.Ports;
using HexagonalArchTest.RestAdapter.Controllers.v1;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;

namespace HexagonalArchTest.RestAdapter.UnitTest.Controllers
{
    public class OrganizationControllerTest
    {
        private OrganizationController _controller;
        private Mock<IObtainOrganization> _requestOrganizationMock;

        [SetUp]
        public void Setup()
        {
            _requestOrganizationMock = new Mock<IObtainOrganization>();
            _controller = new OrganizationController(_requestOrganizationMock.Object);
        }

        [Test]
        public void GetAllOrganizationTestOkResult()
        {
            var response = _controller.Get();
            Assert.IsInstanceOf<OkObjectResult>(response);
        }

        [Test]
        public void GetAllOrgazanitionByIdTestOkResult()
        {
            var response = _controller.Get(1);
            Assert.IsInstanceOf<OkObjectResult>(response);
        }
    }
}
