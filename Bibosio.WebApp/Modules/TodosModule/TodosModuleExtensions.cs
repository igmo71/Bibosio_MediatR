using Bibosio.WebApp.Modules.TodosModule.Application.Commands.Create;
using Bibosio.WebApp.Modules.TodosModule.Application.Commands.Update;
using Bibosio.WebApp.Modules.TodosModule.Infrastructure;
using MediatR;
using MediatR.Pipeline;
using Microsoft.EntityFrameworkCore;

namespace Bibosio.WebApp.Modules.TodosModule
{
    public static class TodosModuleExtensions
    {
        public static IServiceCollection AddTodosModule(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<TodosDbContext>(options =>
            {
                options.UseSqlite(connectionString);
            });

            // UpdateTodo
            services.AddScoped(typeof(IPipelineBehavior<,>), typeof(UpdateTodoPipelineBehavior<,>));

            // CreateTodo
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(CreateTodoPipelineBehavior<,>));

            return services;
        }

        public static IEndpointRouteBuilder MapTodosModuleEndpoints(this IEndpointRouteBuilder routeBuilder)
        {
            CreateTodoEndpoints.MapCreateTodoEndpoint(routeBuilder);
            UpdateTodoEndpoints.MapUpdateTodoEndpoint(routeBuilder);

            return routeBuilder;
        }
    }
}
