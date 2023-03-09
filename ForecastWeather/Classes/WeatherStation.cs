using ForecastWeather.Interfaces;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace ForecastWeather.Classes
{
    public class WeatherStation : ISubject
    {
        private readonly List<IObserver> observers = new();
        private Forecast forecast = null!;
        private string? url = string.Empty;

        public WeatherStation()
        {
            IConfiguration configuration = new ConfigurationBuilder()
                                               .SetBasePath(Directory.GetCurrentDirectory())
                                               .AddJsonFile("appsettings.json")
                                               .Build();

            url = configuration["openweathermap:api_key"];
        }

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(forecast);
            }
        }

        public void RemoveObserver(IObserver observer)
        {
            int index = observers.IndexOf(observer);

            if (index >= 0)
                observers.RemoveAt(index);
        }

        public async Task GetData()
        {
            using var cliente = new HttpClient();
            cliente.DefaultRequestHeaders.Add("Accept", "application/json");

            try
            {
                var response = await cliente.GetAsync(url);


                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                    throw new Exception("Weather not found");

                string resultJSON = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<Forecast>(resultJSON);

                if (data is not null)
                {
                    forecast = data;
                    NotifyObservers();
                }

            }
            catch
            {
                throw;
            }            

        }
    }
}
