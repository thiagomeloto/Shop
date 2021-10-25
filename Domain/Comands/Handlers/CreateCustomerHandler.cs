using MediatR;
using Shop.Domain.Comands.Requests;
using Shop.Domain.Comands.Responses;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Shop.Domain.Comands.Handlers
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
        Task<CreateCustomerResponse> IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>.Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            var result = new CreateCustomerResponse
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Email = request.Email,
                Date = DateTime.Now
            };

            return Task.FromResult(result);
        }
    }
}