using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace WeatherApp.Models
{
    public class Weather
    {
        [JsonProperty("now_dt")]
        public DateTime Date { get; set; }
        public List<Forecast> Forecasts { get; set; }
    }
}
