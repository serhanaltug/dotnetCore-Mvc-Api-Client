using WebClient.Web.Models;

namespace WebClient.Web.Services
{
    public interface IWeatherForecastService
    {
        Task<IEnumerable<WeatherForecastModel>> Find();
    }
}
