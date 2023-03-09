using ForecastWeather.Classes;

namespace ForecastWeatherTest
{
    public class WeatherStationTest
    {
        [Fact]
        public async Task UseCase()
        {
            WeatherStation weatherStation = new();
            TemperatureDisplay temperatureDisplay = new(weatherStation);
            WindDisplay windDisplay = new(weatherStation);
            await weatherStation.GetData();
            var (temp, feelsLike, tempMin, tempMax) = temperatureDisplay.Display();
            var (speed, deg, gust) = windDisplay.Display();

            Assert.True(temp > 0);
            Assert.True(feelsLike > 0);
            Assert.True(tempMin > 0);
            Assert.True(tempMax > 0);
            
            Assert.True(speed > 0);
            Assert.True(deg > 0);
            Assert.True(gust > 0);

        }
    }
}
