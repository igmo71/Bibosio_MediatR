namespace Bibosio.WebApp.Modules.TodosModule.Application.Dto
{
    public class UpdateTodoDto
    {
        public required Guid Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public bool IsComplete { get; set; }
    }
}
