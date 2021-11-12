using HexagonalArchTest.RestAdapter.CustomExceptions.MCHException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexagonalArchTest.RestAdapter.CustomExceptions;

public class MCHProblemDetails : Microsoft.AspNetCore.Mvc.ProblemDetails, IMCHProblemDetails
{
    public MCHProblemDetails()
    {
    }
    public MCHProblemDetails(string detail, string instance, int mchErrorCode)
    {
        Type = "https://example.com/problems/MCHProblems";
        Title = "There was an error getting data from the MCH Data Source.";
        Status = (int)System.Net.HttpStatusCode.InternalServerError;
        Detail = detail;
        Instance = instance;
        MCHErrorCode = mchErrorCode;
    }

    public int MCHErrorCode { get; init; } = -1;

    public MCHProblemDetails Get(string detail, string instance, int mchErrorCode) => new(detail, instance, mchErrorCode);
}

