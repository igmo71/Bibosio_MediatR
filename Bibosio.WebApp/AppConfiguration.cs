using Bibosio.WebApp.Common.Interfaces;
using Bibosio.WebApp.Common.Services;
using Bibosio.WebApp.Modules.TodosModule;
using Bibosio.WebApp.Modules.WeatherForecastModule;

namespace Bibosio.WebApp
{
    public static class AppConfiguration
    {
        public static IServiceCollection AddAppModules(this IServiceCollection services, IConfiguration configuration)
        {           
            services.AddWeatherForecastModule();
            services.AddTodosModule(configuration);

            return services;
        }

        public static IServiceCollection AddAppServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<ICurrentUserService, CurrentUserService>();

            return services;
        }

        public static IEndpointRouteBuilder MapAppModuleEndpoints(this IEndpointRouteBuilder routeBuilder)
        {
            routeBuilder.MapWeatherForecastModuleEndpoints();
            routeBuilder.MapTodosModuleEndpoints();

            return routeBuilder;
        }
    }
}
