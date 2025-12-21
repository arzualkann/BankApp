namespace BankApp.Domain.Entities;

public class IndividualCustomer : Customer
{
    public string IdentityNumber { get; set; } = default!;
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public DateTime BirthDate { get; set; }
    public string? MiddleName { get; set; }
    public string? Gender { get; set; }
    public string? Occupation { get; set; }
    public decimal? MonthlyIncome { get; set; }
}

