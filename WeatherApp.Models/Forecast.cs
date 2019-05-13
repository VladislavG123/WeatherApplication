using Newtonsoft.Json;

namespace WeatherApp.Models
{
    public class Forecast
    {
        public string Date { get; set; }
        public string Sunrise { get; set; }
        public string Sunset { get; set; }
        [JsonProperty("moon_text")]
        public string Moon { get; set; }
        public Parts Parts { get; set; }
    }
}
