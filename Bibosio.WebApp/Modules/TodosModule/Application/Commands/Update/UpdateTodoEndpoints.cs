using AutoMapper;
using Bibosio.WebApp.Modules.TodosModule.Application.Dto;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Bibosio.WebApp.Modules.TodosModule.Application.Commands.Update
{
    public static class UpdateTodoEndpoints
    {
        public static IEndpointRouteBuilder MapUpdateTodoEndpoint(this IEndpointRouteBuilder routeBuilder)
        {
            routeBuilder.MapPut("/todo", (
                [FromServices] IMediator mediator,
                [FromServices] IMapper mapper,
                [FromBody] UpdateTodoDto updateTodoDto) =>
            {
                var command = new UpdateTodoCommand() { UpdateTodoDto = updateTodoDto };
                var result = mediator.Send(command);
                return result;
            });

            return routeBuilder;
        }
    }
}
