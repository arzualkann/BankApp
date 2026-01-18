namespace BankApp.Application.Features.CorporateCustomers.Commands.Update;

public class UpdateCorporateCustomerCommandResponse
{
    public Guid Id { get; set; }
    public string TaxNumber { get; set; } = default!;
    public string CompanyName { get; set; } = default!;
    public DateTime UpdatedDate { get; set; }
}




