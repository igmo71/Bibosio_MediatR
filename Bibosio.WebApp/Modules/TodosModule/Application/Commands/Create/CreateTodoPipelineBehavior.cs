using Bibosio.WebApp.Common.Interfaces;
using MediatR;
using Serilog;

namespace Bibosio.WebApp.Modules.TodosModule.Application.Commands.Create
{
    public class CreateTodoPipelineBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
        where TRequest : CreateTodoCommand
    {
        private readonly ICurrentUserService _currentUserService;

        public CreateTodoPipelineBehavior(ICurrentUserService currentUserService)
        {
            _currentUserService = currentUserService;
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            request.UserId = _currentUserService.Id;
            request.CreateDateTime = DateTime.UtcNow;

            var response = await next();

            Log.Debug("{TRequest} {@Request} {TResponse} {Response} {UserId}",
                typeof(TRequest).Name, request, typeof(TResponse).Name, response, request.UserId);

            return response;
        }
    }
}
