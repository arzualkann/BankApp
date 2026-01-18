using AutoMapper;
using BankApp.Application.Features.IndividualCustomers.Commands.Create;
using BankApp.Application.Features.IndividualCustomers.Commands.Update;
using BankApp.Application.Features.IndividualCustomers.Queries.GetById;
using BankApp.Application.Features.IndividualCustomers.Queries.GetList;
using BankApp.Domain.Entities;

namespace BankApp.Application.Features.IndividualCustomers.Profiles;

public class IndividualCustomerMappingProfile : Profile
{
    public IndividualCustomerMappingProfile()
    {
        CreateMap<CreateIndividualCustomerCommand, IndividualCustomer>();
        CreateMap<IndividualCustomer, CreateIndividualCustomerCommandResponse>();

        CreateMap<UpdateIndividualCustomerCommand, IndividualCustomer>();
        CreateMap<IndividualCustomer, UpdateIndividualCustomerCommandResponse>();

        CreateMap<IndividualCustomer, GetByIdIndividualCustomerQueryResponse>();

        CreateMap<IndividualCustomer, IndividualCustomerListItemDto>();
    }
}




