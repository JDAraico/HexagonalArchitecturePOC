using AutoWrapper.Exceptions;
using HexagonalArchTest.DomainApi.Model;
using HexagonalArchTest.DomainApi.Ports;
using HexagonalArchTest.RestAdapter.CustomExceptions.MCHException;
using Microsoft.AspNetCore.Mvc;

namespace HexagonalArchTest.RestAdapter.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class OrganizationController : ControllerBase
    {
        private readonly IObtainOrganization _obtainOrganization;
        private readonly IMCHProblemDetails _mchProblemDetails;

        public OrganizationController(IObtainOrganization obtainOrganization, IMCHProblemDetails mchProblemDetails)
        {
            _obtainOrganization = obtainOrganization;
            _mchProblemDetails = mchProblemDetails;
        }

        // GET: api/organization
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var result = _obtainOrganization.GetOrganizations();
                return Ok(result);
            }
            catch(System.Exception ex)
            {
                //using custom problem details object
                var problem = _mchProblemDetails.Get(ex.Message, "api/organization", 1003);
                throw new ApiProblemDetailsException(problem);
            }
        }

        // GET: api/organization/1
        [HttpGet]
        [Route("{id}", Name = "GetOrganization")]
        public IActionResult Get(int id)
        {
            try
            {
                var result = _obtainOrganization.GetOrganization(id);
                return Ok(result);
            }
            catch (System.Exception)
            {
                //using the default auto wrapper problem details object
                throw new ApiProblemDetailsException($"Organization with id: {id} does not exist.", (int)System.Net.HttpStatusCode.NotFound);
            }
        }
    }
}
