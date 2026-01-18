namespace BankApp.Application.Features.IndividualCustomers.Commands.Create;

public class CreateIndividualCustomerCommandResponse
{
    public Guid Id { get; set; }
    public string IdentityNumber { get; set; } = default!;
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public DateTime CreatedDate { get; set; }
}




