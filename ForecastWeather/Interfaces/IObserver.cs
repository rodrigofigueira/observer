using ForecastWeather.Classes;

namespace ForecastWeather.Interfaces
{
    public interface IObserver
    {
        public void Update(Forecast forecast);
    }
}
