using BankApp.Core.Repositories;
using BankApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BankingCreditSystem.Application.Services.Repositories
{
    public interface ICreditTypeRepository : IAsyncRepository<CreditType, Guid>
    {
        Task<IList<CreditType>> GetByCustomerTypeAsync(CustomerType customerType);
        Task<IList<CreditType>> GetSubCreditTypesAsync(Guid parentCreditTypeId);
    }
}