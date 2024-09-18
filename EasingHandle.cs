using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LottieJsonGenerator
{
    // Easing Handle class for bezier easing
    public class EasingHandle
    {
        [JsonPropertyName("x")]
        public List<double> X { get; set; } = new List<double> { 0.333, 0.333 }; // Easing X handle

        [JsonPropertyName("y")]
        public List<double> Y { get; set; } = new List<double> { 0, 0 }; // Easing Y handle
    }
}
