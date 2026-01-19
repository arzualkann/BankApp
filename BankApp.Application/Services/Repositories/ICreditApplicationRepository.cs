using BankApp.Core.Repositories;
using BankApp.Domain.Entities;
using BankApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public interface ICreditApplicationRepository : IAsyncRepository<CreditApplication, Guid>
{
    Task<IList<CreditApplication>> GetByCustomerIdAsync(Guid customerId);
    Task<IList<CreditApplication>> GetByCreditTypeIdAsync(Guid creditTypeId);
    Task<IList<CreditApplication>> GetByStatusAsync(CreditApplicationStatus status);
}