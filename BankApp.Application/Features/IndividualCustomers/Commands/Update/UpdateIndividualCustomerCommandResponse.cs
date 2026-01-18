namespace BankApp.Application.Features.IndividualCustomers.Commands.Update;

public class UpdateIndividualCustomerCommandResponse
{
    public Guid Id { get; set; }
    public string IdentityNumber { get; set; } = default!;
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public DateTime UpdatedDate { get; set; }
}




