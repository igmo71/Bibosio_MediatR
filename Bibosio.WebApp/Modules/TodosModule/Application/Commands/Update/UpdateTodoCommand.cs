using Bibosio.WebApp.Modules.TodosModule.Application.Dto;
using Bibosio.WebApp.Modules.TodosModule.Domain;
using MediatR;

namespace Bibosio.WebApp.Modules.TodosModule.Application.Commands.Update
{  
    public class UpdateTodoCommand : IRequest
    {
        public required UpdateTodoDto UpdateTodoDto { get; set; }
        public Guid UserId { get; set; }
        public DateTime EditDateTime { get; set; }/* = DateTime.Now;*/

        public Todo UpdateEntity(Todo todo)
        {
            todo.Name = UpdateTodoDto.Name;
            todo.Description = UpdateTodoDto.Description;
            todo.IsComplete = UpdateTodoDto.IsComplete;
            todo.UserId = UserId;
            todo.EditDateTime = EditDateTime;
            
            return todo;
        }
    }
}
