using BankApp.Core.Repositories;
using BankApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BankingCreditSystem.Application.Services.Repositories
{
    public interface ICreditApplicationRepository : IAsyncRepository<CreditApplication, Guid>
    {
        Task<IList<CreditApplication>> GetByCustomerIdAsync(Guid customerId);
        Task<IList<CreditApplication>> GetByCreditTypeIdAsync(Guid creditTypeId);
        Task<IList<CreditApplication>> GetByStatusAsync(CreditApplicationStatus status);
    }
}