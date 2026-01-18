using BankApp.Core.Repositories;

namespace BankApp.Application.Features.CorporateCustomers.Queries.GetList;

public class GetListCorporateCustomerQueryResponse
{
    public Paginate<CorporateCustomerListItemDto> Items { get; set; } = default!;
}

public class CorporateCustomerListItemDto
{
    public Guid Id { get; set; }
    public string TaxNumber { get; set; } = default!;
    public string CompanyName { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string PhoneNumber { get; set; } = default!;
    public bool IsActive { get; set; }
    public DateTime CreatedDate { get; set; }
}




