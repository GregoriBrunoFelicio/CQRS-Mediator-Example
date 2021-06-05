using CQRS_Mediator.Domain.Commands.Requests;
using CQRS_Mediator.Domain.Commands.Responses;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_Mediator.Domain.Handlers
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            var result = new CreateCustomerResponse
            {
                Id = Guid.NewGuid(),
                Name = "Gregori Felicio",
                Email = "gregory.wow@hotmail.com",
                Date = DateTime.Now
            };

            return Task.FromResult(result);
        }
    }
}
