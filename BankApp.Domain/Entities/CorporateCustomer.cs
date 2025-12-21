namespace BankApp.Domain.Entities;

public class CorporateCustomer : Customer
{
    public string TaxNumber { get; set; } = default!;
    public string CompanyName { get; set; } = default!;
    public string AuthorizedPersonName { get; set; } = default!;
    public string AuthorizedPersonIdentityNumber { get; set; } = default!;
    public string? TradeRegistryNumber { get; set; }
    public DateTime? EstablishmentDate { get; set; }
    public string? Sector { get; set; }
    public decimal? AnnualRevenue { get; set; }
    public int? EmployeeCount { get; set; }
}

