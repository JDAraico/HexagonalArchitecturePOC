using System;
using System.Collections.Generic;
using System.Text;

namespace HexagonalArchTest.DomainApi.Ports
{
    public interface IRequestOrganization<T>
    {
        List<T> GetOrganizations();
        T GetOrganization(int id);
    }
}
