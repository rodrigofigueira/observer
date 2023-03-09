﻿using Newtonsoft.Json;

namespace ForecastWeather.Classes
{
    public class Clouds
    {
        [JsonProperty("all")]
        public int All;
    }

    public class Coord
    {
        [JsonProperty("lon")]
        public double Lon;

        [JsonProperty("lat")]
        public double Lat;
    }

    public class Main
    {
        [JsonProperty("temp")]
        public double Temp;

        [JsonProperty("feels_like")]
        public double FeelsLike;

        [JsonProperty("temp_min")]
        public double TempMin;

        [JsonProperty("temp_max")]
        public double TempMax;

        [JsonProperty("pressure")]
        public int Pressure;

        [JsonProperty("humidity")]
        public int Humidity;

        [JsonProperty("sea_level")]
        public int SeaLevel;

        [JsonProperty("grnd_level")]
        public int GrndLevel;
    }

    public class Forecast
    {
        [JsonProperty("coord")]
        public Coord? Coord;

        [JsonProperty("weather")]
        public List<Weather>? Weather;

        [JsonProperty("base")]
        public string? Base;

        [JsonProperty("main")]
        public Main? Main;

        [JsonProperty("visibility")]
        public int Visibility;

        [JsonProperty("wind")]
        public Wind? Wind;

        [JsonProperty("clouds")]
        public Clouds? Clouds;

        [JsonProperty("dt")]
        public int Dt;

        [JsonProperty("sys")]
        public Sys? Sys;

        [JsonProperty("timezone")]
        public int Timezone;

        [JsonProperty("id")]
        public int Id;

        [JsonProperty("name")]
        public string? Name;

        [JsonProperty("cod")]
        public int Cod;
    }

    public class Sys
    {
        [JsonProperty("type")]
        public int Type;

        [JsonProperty("id")]
        public int Id;

        [JsonProperty("country")]
        public string? Country;

        [JsonProperty("sunrise")]
        public int Sunrise;

        [JsonProperty("sunset")]
        public int Sunset;
    }

    public class Weather
    {
        [JsonProperty("id")]
        public int Id;

        [JsonProperty("main")]
        public string? Main;

        [JsonProperty("description")]
        public string? Description;

        [JsonProperty("icon")]
        public string? Icon;
    }

    public class Wind
    {
        [JsonProperty("speed")]
        public double Speed;

        [JsonProperty("deg")]
        public int Deg;

        [JsonProperty("gust")]
        public double Gust;
    }

}
