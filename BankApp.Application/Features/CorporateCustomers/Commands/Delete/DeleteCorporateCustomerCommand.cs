namespace BankApp.Application.Features.CorporateCustomers.Commands.Delete;

public class DeleteCorporateCustomerCommand
{
    public Guid Id { get; set; }
    public bool Permanent { get; set; } = false;
}




