using BankApp.Core.Repositories;
using BankApp.Domain.Entities;
using BankApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public interface ICreditTypeRepository : IAsyncRepository<CreditType, Guid>
{
    Task<IList<CreditType>> GetByCustomerTypeAsync(CustomerType customerType);
    Task<IList<CreditType>> GetSubCreditTypesAsync(Guid parentCreditTypeId);
}