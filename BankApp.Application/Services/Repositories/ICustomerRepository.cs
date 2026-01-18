using BankApp.Core.Repositories;
using BankApp.Domain.Entities;

namespace BankApp.Application.Services.Repositories;

public interface ICustomerRepository<T> : IAsyncRepository<T, Guid> where T : Customer
{
}

