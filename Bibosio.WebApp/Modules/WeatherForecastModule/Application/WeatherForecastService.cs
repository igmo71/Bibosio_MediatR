using Bibosio.WebApp.Modules.WeatherForecastModule.Domain;

namespace Bibosio.WebApp.Modules.WeatherForecastModule.Application
{
    public interface IWeatherForecastService
    {
        WeatherForecast[] GetWeatherForecast();
    }

    public class WeatherForecastService : IWeatherForecastService
    {
        public WeatherForecast[] GetWeatherForecast()
        {
            var summaries = new[]
            {
                "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
            };

            var forecast = Enumerable.Range(1, 5).Select(index =>
                    new WeatherForecast
                    {
                        Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                        TemperatureC = Random.Shared.Next(-20, 55),
                        Summary = summaries[Random.Shared.Next(summaries.Length)]
                    })
                    .ToArray();
            return forecast;
        }
    }
}
