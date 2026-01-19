using BankApp.Application.Features.IndividualCustomers.Commands.Create;
using BankApp.Application.Features.IndividualCustomers.Commands.Delete;
using BankApp.Application.Features.IndividualCustomers.Commands.Update;
using BankApp.Application.Features.IndividualCustomers.Dtos.Requests;
using BankApp.Application.Features.IndividualCustomers.Queries.GetById;
using BankApp.Application.Features.IndividualCustomers.Queries.GetList;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BankApp.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class IndividualCustomersController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateIndividualCustomerCommand createIndividualCustomerCommand)
    {
        var result = await Mediator.Send(createIndividualCustomerCommand);
        return Created("", result);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateIndividualCustomerCommand updateIndividualCustomerCommand)
    {
        var result = await Mediator.Send(updateIndividualCustomerCommand);
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        var command = new DeleteIndividualCustomerCommand { Id = id };
        var result = await Mediator.Send(command);
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        var query = new GetByIdIndividualCustomerQuery { Id = id };
        var result = await Mediator.Send(query);
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] GetListIndividualCustomerQuery getListIndividualCustomerQuery)
    {
        var result = await Mediator.Send(getListIndividualCustomerQuery);
        return Ok(result);
    }
} 

