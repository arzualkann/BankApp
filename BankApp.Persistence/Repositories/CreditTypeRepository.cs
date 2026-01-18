using BankApp.Core.Repositories;
using BankApp.Application.Services.Repositories;
using BankApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingCreditSystem.Application.Services.Repositories;

namespace BankApp.Persistence.Repositories
{
    public class CreditTypeRepository : EfRepositoryBase<CreditType, Guid, BaseDbContext>, ICreditTypeRepository
    {
        public CreditTypeRepository(BaseDbContext context) : base(context)
        {
        }

        public async Task<IList<CreditType>> GetByCustomerTypeAsync(CustomerType customerType)
        {
            return await Context.CreditTypes
                .Where(c => c.CustomerType == customerType)
                .ToListAsync();
        }

        public async Task<IList<CreditType>> GetSubCreditTypesAsync(Guid parentCreditTypeId)
        {
            return await Context.CreditTypes
                .Where(c => c.ParentCreditTypeId == parentCreditTypeId)
                .ToListAsync();
        }
    }
}