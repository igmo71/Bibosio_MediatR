using Bibosio.WebApp.Modules.TodosModule.Infrastructure;
using MediatR;

namespace Bibosio.WebApp.Modules.TodosModule.Application.Commands.Create
{
    public class CreateTodoHandler : IRequestHandler<CreateTodoCommand, Guid>
    {
        private readonly TodosDbContext _dbContext;

        public CreateTodoHandler(TodosDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateTodoCommand command, CancellationToken cancellationToken)
        {
            var entity = command.CreateEntity();

            await _dbContext.Todos.AddAsync(entity, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return entity.Id;
        }
    }
}
