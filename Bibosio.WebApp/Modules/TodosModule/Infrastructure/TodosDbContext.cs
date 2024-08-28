using Bibosio.WebApp.Modules.TodosModule.Domain;
using Bibosio.WebApp.Modules.TodosModule.Infrastructure.EntityTypeConfigurations;
using Microsoft.EntityFrameworkCore;

namespace Bibosio.WebApp.Modules.TodosModule.Infrastructure
{
    public class TodosDbContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }

        public TodosDbContext(DbContextOptions<TodosDbContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("todo");

            modelBuilder.ApplyConfiguration(new TodoConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
