using Newtonsoft.Json;

namespace WeatherApp.Models
{
    [JsonObject("Envelope")]
    public class Position
    {
        public string LowerCorner { get; set; }
        public string UpperCorner { get; set; }
    }
}
