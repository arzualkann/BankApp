using BankApp.Application.Services.Repositories;
using BankApp.Domain.Entities;
using BankApp.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace BankApp.Persistence.Repositories;

public class CorporateCustomerRepository : CustomerRepository<CorporateCustomer>, ICorporateCustomerRepository
{
    public CorporateCustomerRepository(BaseDbContext context) : base(context)
    {
    }
} 


