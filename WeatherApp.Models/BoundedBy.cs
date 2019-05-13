using Newtonsoft.Json;

namespace WeatherApp.Models
{
    public class BoundedBy
    {
        [JsonProperty("Envelope")]
        public Position Position { get; set; }
    }
}
