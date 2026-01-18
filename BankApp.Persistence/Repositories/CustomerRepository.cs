using BankApp.Application.Services.Repositories;
using BankApp.Core.Repositories;
using BankApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BankApp.Persistence.Repositories
{
    public class CustomerRepository<T> : EfRepositoryBase<T, Guid, BaseDbContext>, ICustomerRepository<T>
        where T : Customer
    {
        public CustomerRepository(BaseDbContext context) : base(context)
        {
        }
    }
}
