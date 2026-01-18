namespace BankApp.Application.Features.IndividualCustomers.Commands.Delete;

public class DeleteIndividualCustomerCommand
{
    public Guid Id { get; set; }
    public bool Permanent { get; set; } = false;
}




