using Bibosio.WebApp.Modules.TodosModule.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bibosio.WebApp.Modules.TodosModule.Infrastructure.EntityTypeConfigurations
{
    public class TodoConfiguration : IEntityTypeConfiguration<Todo>
    {
        public void Configure(EntityTypeBuilder<Todo> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(p => p.Name).IsRequired().HasMaxLength(64);
            builder.Property(t => t.Description).HasMaxLength(264);
        }
    }
}
