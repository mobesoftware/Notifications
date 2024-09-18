using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottieJsonGenerator
{
    using System.Text.Json.Serialization;

    // PolyStarShape class for handling both polygons and star shapes
    public class PolyStarShape : Shape
    {
        public PolyStarShape()
        {
            Type = "sr"; // PolyStar type identifier in Lottie JSON
            Name = "PolyStar";
        }

        // Star type: 1 for Star, 2 for Polygon
        [JsonPropertyName("sy")]
        public int StarType { get; set; } = 1; // Default to Star

        // Position of the PolyStar
        [JsonPropertyName("p")]
        public AnimatedPosition Position { get; set; } = new AnimatedPosition
        {
            Animated = 0,
            K = new List<double> { 249.313, 254.472 } // Default position
        };

        // Rotation of the PolyStar
        [JsonPropertyName("r")]
        public AnimatedNumber Rotation { get; set; } = new AnimatedNumber
        {
            Animated = 0,
            K = 0 // Default rotation
        };

        // Number of points in the PolyStar
        [JsonPropertyName("pt")]
        public AnimatedNumber Points { get; set; } = new AnimatedNumber
        {
            Animated = 0,
            K = 5 // Default to 5 points
        };

        // Outer radius of the PolyStar
        [JsonPropertyName("or")]
        public AnimatedNumber OuterRadius { get; set; } = new AnimatedNumber
        {
            Animated = 0,
            K = 200 // Default outer radius
        };

        // Outer roundness of the PolyStar
        [JsonPropertyName("os")]
        public AnimatedNumber OuterRoundness { get; set; } = new AnimatedNumber
        {
            Animated = 0,
            K = 0 // Default outer roundness
        };

        // Inner radius of the PolyStar (only for stars)
        [JsonPropertyName("ir")]
        public AnimatedNumber InnerRadius { get; set; } = new AnimatedNumber
        {
            Animated = 0,
            K = 100 // Default inner radius (only used if StarType = 1)
        };

        // Inner roundness of the PolyStar (only for stars)
        [JsonPropertyName("is")]
        public AnimatedNumber InnerRoundness { get; set; } = new AnimatedNumber
        {
            Animated = 0,
            K = 0 // Default inner roundness
        };
    }

}
