using ForecastWeather.Interfaces;

namespace ForecastWeather.Classes
{
    public class TemperatureDisplay : IObserver
    {
        readonly ISubject weatherStation;
        private double Temp = 0;
        private double FeelsLike = 0;
        private double TempMin = 0;
        private double TempMax = 0;


        public TemperatureDisplay(ISubject _weatherStation)
        {
            weatherStation = _weatherStation;
            weatherStation.AddObserver(this);
        }

        public void Update(Forecast forecast)
        {
            if(forecast.Main?.Temp > 0 &&
               forecast.Main?.FeelsLike > 0 &&
               forecast.Main?.TempMin > 0 &&
               forecast.Main?.TempMax > 0)
            {
                Temp = forecast.Main.Temp;
                FeelsLike = forecast.Main.FeelsLike;
                TempMin = forecast.Main.TempMin;
                TempMax = forecast.Main.TempMax;
            }
        }

        public (double temp, double feelsLike, double tempMin, double tempMax) Display()
        {
            return (Temp, FeelsLike, TempMin, TempMax);
        }

    }
    
}
