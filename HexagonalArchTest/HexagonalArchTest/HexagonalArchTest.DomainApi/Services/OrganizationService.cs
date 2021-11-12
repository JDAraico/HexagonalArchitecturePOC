using HexagonalArchTest.DomainApi.Model;
using HexagonalArchTest.DomainApi.Ports;
using System;
using System.Collections.Generic;
using System.Text;

namespace HexagonalArchTest.DomainApi.Services
{
    public class OrganizationService : IObtainOrganization
    {
        private readonly IRequestOrganization<Organization> requestOrganization;
        public OrganizationService(IRequestOrganization<Organization> requestOrganization)
        {
            this.requestOrganization = requestOrganization;
        }

        public Organization GetOrganization(int id)
        {
            return requestOrganization.GetOrganization(id);
        }

        public List<Organization> GetOrganizations()
        {
            return requestOrganization.GetOrganizations();
        }
    }
}
