using Microsoft.AspNetCore.Mvc;

namespace BankApp.Core.CrossCuttingConcerns.Exceptions.HttpProblemDetails;

public class InternalServerErrorProblemDetails : ProblemDetails
{
    public InternalServerErrorProblemDetails(string detail)
    {
        Title = "Internal Server Error";
        Detail = detail;
        Status = 500;
        Type = "https://example.com/probs/internal";
    }
}

