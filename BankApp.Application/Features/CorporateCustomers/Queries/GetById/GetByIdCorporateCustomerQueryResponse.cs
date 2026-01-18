namespace BankApp.Application.Features.CorporateCustomers.Queries.GetById;

public class GetByIdCorporateCustomerQueryResponse
{
    public Guid Id { get; set; }
    public string TaxNumber { get; set; } = default!;
    public string CompanyName { get; set; } = default!;
    public string AuthorizedPersonName { get; set; } = default!;
    public string AuthorizedPersonIdentityNumber { get; set; } = default!;
    public string? TradeRegistryNumber { get; set; }
    public DateTime? EstablishmentDate { get; set; }
    public string? Sector { get; set; }
    public decimal? AnnualRevenue { get; set; }
    public int? EmployeeCount { get; set; }
    public string PhoneNumber { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string Address { get; set; } = default!;
    public string City { get; set; } = default!;
    public string Country { get; set; } = default!;
    public string PostalCode { get; set; } = default!;
    public bool IsActive { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
}




