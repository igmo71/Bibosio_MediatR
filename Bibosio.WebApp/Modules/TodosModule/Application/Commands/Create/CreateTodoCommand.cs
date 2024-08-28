using Bibosio.WebApp.Modules.TodosModule.Application.Dto;
using Bibosio.WebApp.Modules.TodosModule.Domain;
using MediatR;

namespace Bibosio.WebApp.Modules.TodosModule.Application.Commands.Create
{
    public class CreateTodoCommand : IRequest<Guid>
    {
        public required CreateTodoDto CreateTodoDto { get; set; }
        public Guid UserId { get; set; }
        public DateTime CreateDateTime { get; set; }/* = DateTime.Now;*/

        public Todo CreateEntity()
        {
            return new Todo
            {
                Name = CreateTodoDto.Name,
                Description = CreateTodoDto.Description,
                UserId = UserId,
                CreateDateTime = CreateDateTime,
                EditDateTime = null,
                IsComplete = false
            };
        }
    }
}
