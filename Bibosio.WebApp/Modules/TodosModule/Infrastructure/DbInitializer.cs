namespace Bibosio.WebApp.Modules.TodosModule.Infrastructure
{
    public class DbInitializer
    {
        public static void Initialize(TodosDbContext dbContext)
        {
            dbContext.Database.EnsureCreated();
        }
    }
}
