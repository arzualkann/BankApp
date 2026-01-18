using BankApp.Core.Repositories;

namespace BankApp.Domain.Entities;

public abstract class Customer : Entity<Guid>
{
    public string PhoneNumber { get; set; } = default!;
    public string Email { get; set; } = default!; 
    public string Address { get; set; } = default!;
    public string City { get; set; } = default!;
    public string Country { get; set; } = default!;
    public string PostalCode { get; set; } = default!;
    public bool IsActive { get; set; } = true;
}

