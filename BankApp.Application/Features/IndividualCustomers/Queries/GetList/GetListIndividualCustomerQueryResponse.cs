using BankApp.Core.Repositories;

namespace BankApp.Application.Features.IndividualCustomers.Queries.GetList;

public class GetListIndividualCustomerQueryResponse
{
    public Paginate<IndividualCustomerListItemDto> Items { get; set; } = default!;
}

public class IndividualCustomerListItemDto
{
    public Guid Id { get; set; }
    public string IdentityNumber { get; set; } = default!;
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string PhoneNumber { get; set; } = default!;
    public bool IsActive { get; set; }
    public DateTime CreatedDate { get; set; }
}




