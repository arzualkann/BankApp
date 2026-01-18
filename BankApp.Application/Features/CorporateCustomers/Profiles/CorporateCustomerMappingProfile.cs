using AutoMapper;
using BankApp.Application.Features.CorporateCustomers.Commands.Create;
using BankApp.Application.Features.CorporateCustomers.Commands.Update;
using BankApp.Application.Features.CorporateCustomers.Queries.GetById;
using BankApp.Application.Features.CorporateCustomers.Queries.GetList;
using BankApp.Domain.Entities;

namespace BankApp.Application.Features.CorporateCustomers.Profiles;

public class CorporateCustomerMappingProfile : Profile
{
    public CorporateCustomerMappingProfile()
    {
        CreateMap<CreateCorporateCustomerCommand, CorporateCustomer>();
        CreateMap<CorporateCustomer, CreateCorporateCustomerCommandResponse>();

        CreateMap<UpdateCorporateCustomerCommand, CorporateCustomer>();
        CreateMap<CorporateCustomer, UpdateCorporateCustomerCommandResponse>();

        CreateMap<CorporateCustomer, GetByIdCorporateCustomerQueryResponse>();

        CreateMap<CorporateCustomer, CorporateCustomerListItemDto>();
    }
}




