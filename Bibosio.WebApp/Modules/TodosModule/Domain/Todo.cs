namespace Bibosio.WebApp.Modules.TodosModule.Domain
{
    public class Todo
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public bool IsComplete { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime? EditDateTime { get; set; }
        public Guid UserId { get; set; }
    }
}
