using ForecastWeather.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForecastWeather.Classes
{
    public class WindDisplay : IObserver
    {
        public double Speed;
        public int Deg;
        public double Gust;
        private readonly ISubject weatherStation = null!;

        public WindDisplay(ISubject _weatherStation)
        {
            weatherStation = _weatherStation;
            weatherStation.AddObserver(this);
        }

        public void Update(Forecast forecast)
        {
            if (forecast.Wind?.Speed > 0 &&
               forecast.Wind?.Gust > 0 &&
               forecast.Wind?.Deg > 0)
            {
                Speed = forecast.Wind.Speed;
                Gust = forecast.Wind.Gust;
                Deg = forecast.Wind.Deg;
            }
        }

        public (double speed, int deg, double gust) Display()
        {
            return (Speed, Deg, Gust);
        }
    }
}
