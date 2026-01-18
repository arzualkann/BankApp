using Microsoft.AspNetCore.Mvc;

namespace BankApp.Core.CrossCuttingConcerns.Exceptions.HttpProblemDetails;

public class NotFoundProblemDetails : ProblemDetails
{
    public NotFoundProblemDetails(string detail)
    {
        Title = "Not Found";
        Detail = detail;
        Status = 404;
        Type = "https://example.com/probs/not-found";
    }
}

