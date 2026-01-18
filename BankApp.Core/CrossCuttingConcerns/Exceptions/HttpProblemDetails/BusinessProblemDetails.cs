using Microsoft.AspNetCore.Mvc;

namespace BankApp.Core.CrossCuttingConcerns.Exceptions.HttpProblemDetails;

public class BusinessProblemDetails : ProblemDetails
{
    public BusinessProblemDetails(string detail)
    {
        Title = "Business Rule Violation";
        Detail = detail;
        Status = 400;
        Type = "https://example.com/probs/business";
    }
}

