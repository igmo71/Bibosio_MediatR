using AutoMapper;
using Bibosio.WebApp.Modules.TodosModule.Application.Dto;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Bibosio.WebApp.Modules.TodosModule.Application.Commands.Create
{
    public static class CreateTodoEndpoints
    {
        public static IEndpointRouteBuilder MapCreateTodoEndpoint(this IEndpointRouteBuilder routeBuilder)
        {
            routeBuilder.MapPost("/todo", (
                [FromServices] IMediator mediator,
                [FromServices] IMapper mapper,
                [FromBody] CreateTodoDto createTodoDto) =>
            {
                var command = new CreateTodoCommand() { CreateTodoDto = createTodoDto };  //mapper.Map<CreateTodoCommand>(createTodoDto);
                var result = mediator.Send(command);
                return result;
            });

            return routeBuilder;
        }
    }
}
