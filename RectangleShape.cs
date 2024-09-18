namespace LottieJsonGenerator
{
    using System.Text.Json.Serialization;

    // RectangleShape class
    public class RectangleShape : Shape
    {
        public RectangleShape()
        {
            Type = "rc"; // Rectangle type identifier in Lottie JSON
            Name = "Rectangle";
        }

        // Position property that defines the center of the rectangle
        [JsonPropertyName("p")]
        public AnimatedValue Position { get; set; } = new AnimatedValue
        {
            Animated = 0,
            K = new List<double> { 256, 256 } // Center at (256, 256)
        };

        // Size property that defines the width and height of the rectangle
        [JsonPropertyName("s")]
        public AnimatedValue Size { get; set; } = new AnimatedValue
        {
            Animated = 0,
            K = new List<double> { 256, 256 } // Size (256, 256)
        };

        // Rounded corners radius
        [JsonPropertyName("r")]
        public AnimatedValue Roundness { get; set; } = new AnimatedValue
        {
            Animated = 0,
            K = 0 // No rounding by default
        };
    }

}
