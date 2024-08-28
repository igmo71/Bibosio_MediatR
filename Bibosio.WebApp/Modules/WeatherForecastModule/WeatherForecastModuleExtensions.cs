using Bibosio.WebApp.Modules.WeatherForecastModule.Application;

namespace Bibosio.WebApp.Modules.WeatherForecastModule
{
    public static class WeatherForecastModuleExtensions
    {
        public static IServiceCollection AddWeatherForecastModule(this IServiceCollection services)
        {
            services.AddScoped<IWeatherForecastService, WeatherForecastService>();
            
            return services;
        }

        public static IEndpointRouteBuilder MapWeatherForecastModuleEndpoints(this IEndpointRouteBuilder routeBuilder)
        {
            routeBuilder.MapGet("/weatherforecast", (HttpContext httpContext, IWeatherForecastService service) =>
            {
                var forecast = service.GetWeatherForecast();
                return forecast;
            })
            .WithName("GetWeatherForecast");

            return routeBuilder;
        }
    }
}
