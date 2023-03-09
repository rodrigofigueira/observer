using ForecastWeather.Classes;
using Newtonsoft.Json;

namespace ForecastWeatherTest
{
    public class CastTest
    {
        [Fact]
        public void Should_Convert()
        {
            string directoryPath = Path.Combine(Directory.GetCurrentDirectory(), "Data", "weather_suzano.json");
            string fileContent = File.ReadAllText(directoryPath);
            var forecast = JsonConvert.DeserializeObject<Forecast>(fileContent);
            Assert.Equal(-46.3108, forecast?.Coord?.Lon);
            Assert.Equal(-23.5425, forecast?.Coord?.Lat);
            Assert.Equal(27.85, forecast?.Main?.Temp);
        }
    }
}