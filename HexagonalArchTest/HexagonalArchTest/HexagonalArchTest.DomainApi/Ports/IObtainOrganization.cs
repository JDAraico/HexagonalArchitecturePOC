using HexagonalArchTest.DomainApi.Model;
using System.Collections.Generic;

namespace HexagonalArchTest.DomainApi.Ports
{
    public interface IObtainOrganization
    {
        List<Organization> GetOrganizations();
        Organization GetOrganization(int id);
    }
}
