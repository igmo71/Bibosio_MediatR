using Scalar.AspNetCore;
using Serilog;
using System.Reflection;

namespace Bibosio.WebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddAuthorization();

            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            builder.Services.AddSerilog(options =>
            {
                options.ReadFrom.Configuration(builder.Configuration);
            });

            var executingAssembly = Assembly.GetExecutingAssembly();

            builder.Services.AddMediatR(config =>
            {
                config.RegisterServicesFromAssembly(executingAssembly);
            });

            builder.Services.AddAutoMapper(executingAssembly);

            builder.Services.AddHttpContextAccessor();

            builder.Services.AddAppServices(builder.Configuration);
            builder.Services.AddAppModules(builder.Configuration);

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                app.MapScalarApiReference();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapAppModuleEndpoints();

            app.Run();
        }
    }
}
