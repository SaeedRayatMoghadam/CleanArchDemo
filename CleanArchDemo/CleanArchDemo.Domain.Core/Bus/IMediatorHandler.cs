using System.Threading.Tasks;
using CleanArchDemo.Domain.Core.Commands;

namespace CleanArchDemo.Domain.Core.Bus
{
    public interface IMediatorHandler
    {
        Task SendCommand<T>(T command) where T : Command;
    }
}