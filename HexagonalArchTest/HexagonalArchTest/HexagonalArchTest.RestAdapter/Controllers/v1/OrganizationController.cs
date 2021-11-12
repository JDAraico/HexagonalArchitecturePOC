using HexagonalArchTest.DomainApi.Model;
using HexagonalArchTest.DomainApi.Ports;
using Microsoft.AspNetCore.Mvc;

namespace HexagonalArchTest.RestAdapter.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class OrganizationController : ControllerBase
    {
        private readonly IObtainOrganization _obtainOrganization;

        public OrganizationController(IObtainOrganization obtainOrganization)
        {
            _obtainOrganization = obtainOrganization;
        }

        // GET: api/organization
        [HttpGet]
        public IActionResult Get()
        {
            var result = _obtainOrganization.GetOrganizations();
            return Ok(result);
        }

        // GET: api/organization/1
        [HttpGet]
        [Route("{id}", Name = "GetOrganization")]
        public IActionResult Get(int id)
        {
            var result = _obtainOrganization.GetOrganization(id);
            return Ok(result);
        }
    }
}
