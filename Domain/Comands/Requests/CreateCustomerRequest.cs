using MediatR;
using Shop.Domain.Comands.Responses;

namespace Shop.Domain.Comands.Requests
{
    public class CreateCustomerRequest : IRequest<CreateCustomerResponse>
    {
        public string  Name { get; set; }

        public string Email { get; set; }
    }
}