using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LottieJsonGenerator
{
    // Class for animated numeric properties
    public class AnimatedNumber
    {
        [JsonPropertyName("a")]
        public int Animated { get; set; } = 0; // 0 = static, 1 = animated

        // Static value or keyframe values if animated
        [JsonPropertyName("k")]
        public double K { get; set; }
    }
}
