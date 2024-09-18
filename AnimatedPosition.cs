using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LottieJsonGenerator
{
    // Class for animated position properties
    public class AnimatedPosition
    {
        [JsonPropertyName("a")]
        public int Animated { get; set; } = 0; // 0 = static, 1 = animated

        // Static position or keyframe values if animated
        [JsonPropertyName("k")]
        public List<double> K { get; set; }
    }
}
