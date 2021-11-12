using HexagonalArchTest.RestAdapter.CustomExceptions.MCHException;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexagonalArchTest.RestAdapter.CustomExceptions
{
    public static class CustomExceptionsExtension
    {
        public static void AddCustomExceptions(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IMCHProblemDetails, MCHProblemDetails>();
        }
    }
}
