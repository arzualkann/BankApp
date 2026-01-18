namespace BankApp.Application.Features.CorporateCustomers.Commands.Create;

public class CreateCorporateCustomerCommandResponse
{
    public Guid Id { get; set; }
    public string TaxNumber { get; set; } = default!;
    public string CompanyName { get; set; } = default!;
    public DateTime CreatedDate { get; set; }
}




