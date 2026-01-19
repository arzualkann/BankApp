using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using AutoMapper;
using BankApp.Application.Features.IndividualCustomers.Dtos.Requests;
using BankApp.Application.Features.IndividualCustomers.Dtos.Responses;
using BankApp.Application.Features.IndividualCustomers.Rules;
using BankApp.Application.Services.Repositories;
using BankApp.Application.Features.IndividualCustomers.Constants;

namespace BankApp.Application.Features.IndividualCustomers.Commands.Update;

public class UpdateIndividualCustomerCommand : IRequest<UpdatedIndividualCustomerResponse>
{
    public UpdateIndividualCustomerRequest Request { get; set; } = default!;

    public class UpdateIndividualCustomerCommandHandler : IRequestHandler<UpdateIndividualCustomerCommand, UpdatedIndividualCustomerResponse>
    {
        private readonly IIndividualCustomerRepository _individualCustomerRepository;
        private readonly IMapper _mapper;
        private readonly IndividualCustomerBusinessRules _businessRules;

        public UpdateIndividualCustomerCommandHandler(
            IIndividualCustomerRepository individualCustomerRepository,
            IMapper mapper,
            IndividualCustomerBusinessRules businessRules)
        {
            _individualCustomerRepository = individualCustomerRepository;
            _mapper = mapper;
            _businessRules = businessRules;
        }

        public async Task<UpdatedIndividualCustomerResponse> Handle(UpdateIndividualCustomerCommand command, CancellationToken cancellationToken)
        {
            await _businessRules.CustomerShouldExistWhenRequested(command.Request.Id);

            var individualCustomer = await _individualCustomerRepository.GetAsync(c => c.Id == command.Request.Id);
            _mapper.Map(command.Request, individualCustomer);

            var updatedCustomer = await _individualCustomerRepository.UpdateAsync(individualCustomer);
            var response = _mapper.Map<UpdatedIndividualCustomerResponse>(updatedCustomer);
            response.Message = IndividualCustomerMessages.CustomerUpdated;

            return response;
        }
    }
} 




