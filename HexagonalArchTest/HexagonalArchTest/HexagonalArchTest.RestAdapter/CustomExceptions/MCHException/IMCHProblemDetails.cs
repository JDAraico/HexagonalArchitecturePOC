using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexagonalArchTest.RestAdapter.CustomExceptions.MCHException
{
    public interface IMCHProblemDetails
    {
        MCHProblemDetails Get(string detail, string instance, int mchErrorCode);
    }
}
