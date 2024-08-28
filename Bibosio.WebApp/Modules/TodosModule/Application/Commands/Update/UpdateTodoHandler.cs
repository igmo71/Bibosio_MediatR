using Bibosio.WebApp.Common.Exceptions;
using Bibosio.WebApp.Modules.TodosModule.Domain;
using Bibosio.WebApp.Modules.TodosModule.Infrastructure;
using MediatR;

namespace Bibosio.WebApp.Modules.TodosModule.Application.Commands.Update
{
    public class UpdateTodoHandler : IRequestHandler<UpdateTodoCommand>
    {
        private readonly TodosDbContext _dbContext;

        public UpdateTodoHandler(TodosDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Handle(UpdateTodoCommand command, CancellationToken cancellationToken)
        {
            var updateEntity = await _dbContext.Todos.FindAsync(command.UpdateTodoDto.Id, cancellationToken)
                ?? throw new EntityNotFoundException(nameof(Todo), command.UpdateTodoDto.Id);

            command.UpdateEntity(updateEntity);

            await _dbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
