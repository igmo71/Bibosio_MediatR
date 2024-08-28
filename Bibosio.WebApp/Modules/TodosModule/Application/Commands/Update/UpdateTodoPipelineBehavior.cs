using Bibosio.WebApp.Common.Interfaces;
using MediatR;
using Serilog;

namespace Bibosio.WebApp.Modules.TodosModule.Application.Commands.Update
{
    public class UpdateTodoPipelineBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
        where TRequest : UpdateTodoCommand
    {
        private readonly ICurrentUserService _currentUserService;

        public UpdateTodoPipelineBehavior(ICurrentUserService currentUserService)
        {
            _currentUserService = currentUserService;
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            request.UserId = _currentUserService.Id;
            request.EditDateTime = DateTime.Now;

            var result = await next();

            Log.Debug("{TRequest} {@Request} {UserId}",
                typeof(TRequest).Name, request, request.UserId);

            return result;
        }
    }
}
