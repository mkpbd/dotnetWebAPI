using Contracts;
using Microsoft.AspNetCore.Mvc;

namespace cleanArchitecture.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILoggerManager _logger;

        public WeatherForecastController(ILoggerManager logger)
        {
            _logger = logger;
        }

        [HttpGet(Name ="logger")]
        public string Get()
        {
            _logger.LogInfo("This is info message from WeatherForecastController.");
            _logger.LogDebug("This is debug message from WeatherForecastController.");
            _logger.LogWarn("This is warn message from WeatherForecastController.");
            _logger.LogError("This is error message from WeatherForecastController.");

            return "hello logger";
        }


        private static readonly string[] Summaries =
        [
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        ];

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> GetWether()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
