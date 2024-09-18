using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LottieJsonGenerator
{
    public class Tangent
    {
        [JsonPropertyName("x")]
        public double X { get; set; } = 0.0;

        [JsonPropertyName("y")]
        public double Y { get; set; } = 0.0;
    }
}
