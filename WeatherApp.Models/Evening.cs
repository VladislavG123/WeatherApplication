using Newtonsoft.Json;

namespace WeatherApp.Models
{
    public class Evening
    {
        public string Condition { get; set; }
        [JsonProperty("temp_min")]
        public int TempMin { get; set; }
        [JsonProperty("temp_max")]
        public int TempMax { get; set; }
        [JsonProperty("temp_avg")]
        public int TempAvg { get; set; }
        [JsonProperty("feels_like")]
        public int FeelsLike { get; set; }
        [JsonProperty("wind_speed")]
        public double WindSpeed { get; set; }
        [JsonProperty("wind_dir")]
        public string WindDirrection { get; set; }
        public double Cloudness { get; set; }
    }
}
