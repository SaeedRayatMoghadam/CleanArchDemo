using System.Threading.Tasks;
using CleanArchDemo.Domain.Core.Bus;
using CleanArchDemo.Domain.Core.Commands;
using MediatR;

namespace CleanArchDemo.Infra.Bus
{
    public sealed class InMemoryBus : IMediatorHandler
    {
        private readonly IMediator _mediator;

        public InMemoryBus(IMediator mediator)
        {
            _mediator = mediator;
        }

        public Task SendCommand<T>(T command) where T : Command
        {
            return _mediator.Send(command);
        }
    }
}