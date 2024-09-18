using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LottieJsonGenerator
{
    // Simplified AnimatedValue class for properties that can be static or animated
    public class AnimatedValue
    {
        [JsonPropertyName("a")]
        public int Animated { get; set; } = 0; // 0 = static, 1 = animated

        // Static value for the property
        [JsonPropertyName("k")]
        public object K { get; set; }
    }
}
