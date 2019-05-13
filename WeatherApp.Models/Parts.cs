using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    public class Parts
    {
        public Night Night { get; set; }
        public Morning Morning { get; set; }
        public Day Day { get; set; }
        public Evening Evening { get; set; }
    }
}
