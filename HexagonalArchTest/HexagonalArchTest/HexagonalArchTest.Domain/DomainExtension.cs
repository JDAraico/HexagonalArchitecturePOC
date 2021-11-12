using HexagonalArchTest.DomainApi.Ports;
using HexagonalArchTest.DomainApi.Services;
using Microsoft.Extensions.DependencyInjection;

namespace HexagonalArchTest.Organization
{
    public static class DomainExtension
    {
        public static void AddDomain(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient(typeof(IRequestOrganization<>), typeof(OrganizationDomain<>));
            serviceCollection.AddTransient(typeof(IObtainOrganization), typeof(OrganizationService));
        }
    }
}
