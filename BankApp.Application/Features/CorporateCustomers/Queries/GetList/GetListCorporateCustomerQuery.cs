namespace BankApp.Application.Features.CorporateCustomers.Queries.GetList;

public class GetListCorporateCustomerQuery
{
    public int PageNumber { get; set; } = 1;
    public int PageSize { get; set; } = 10;
    public string? SearchTerm { get; set; }
}




