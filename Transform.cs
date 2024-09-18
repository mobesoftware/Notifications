using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottieJsonGenerator
{
    using System.Text.Json.Serialization;
    using System.Collections.Generic;

    // Class representing the Transform properties for layers and shapes
    public class Transform
    {
        // Anchor point: position relative to its parent around which transformations are applied
        [JsonPropertyName("a")]
        public AnimatedPosition AnchorPoint { get; set; } = new AnimatedPosition
        {
            Animated = 0,
            K = new List<double> { 0, 0 } // Default anchor point at (0, 0)
        };

        // Position: controls the translation of the shape or layer
        [JsonPropertyName("p")]
        public AnimatedPosition Position { get; set; } = new AnimatedPosition
        {
            Animated = 0,
            K = new List<double> { 0, 0 } // Default position at (0, 0)
        };

        // Scale: controls the scale factor, 100 means no scaling
        [JsonPropertyName("s")]
        public AnimatedPosition Scale { get; set; } = new AnimatedPosition
        {
            Animated = 0,
            K = new List<double> { 100, 100 } // Default scale (100%, 100%)
        };

        // Rotation: rotation in degrees, clockwise
        [JsonPropertyName("r")]
        public AnimatedNumber Rotation { get; set; } = new AnimatedNumber
        {
            Animated = 0,
            K = 0 // Default rotation at 0 degrees
        };

        // Skew: amount of skew as an angle in degrees
        [JsonPropertyName("sk")]
        public AnimatedNumber Skew { get; set; } = new AnimatedNumber
        {
            Animated = 0,
            K = 0 // Default skew at 0 degrees
        };

        // Skew Axis: direction at which skew is applied, in degrees
        [JsonPropertyName("sa")]
        public AnimatedNumber SkewAxis { get; set; } = new AnimatedNumber
        {
            Animated = 0,
            K = 0 // Default skew axis at 0 degrees (X axis)
        };

        // Opacity: opacity level, 100 means fully opaque
        [JsonPropertyName("o")]
        public AnimatedNumber Opacity { get; set; } = new AnimatedNumber
        {
            Animated = 0,
            K = 100 // Default opacity at 100%
        };
    }
}
