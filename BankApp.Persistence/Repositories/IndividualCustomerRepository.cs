using BankApp.Application.Services.Repositories;
using BankApp.Domain.Entities;
using BankApp.Persistence.Contexts;
using BankApp.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BankApp.Persistence.Repositories
{
    public class IndividualCustomerRepository : CustomerRepository<IndividualCustomer>, IIndividualCustomerRepository
    {
        public IndividualCustomerRepository(BaseDbContext context) : base(context)
        {
        }
    }
}
