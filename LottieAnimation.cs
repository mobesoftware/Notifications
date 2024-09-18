namespace LottieJsonGenerator
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class LottieAnimation
    {
        [JsonPropertyName("v")]
        public string Version { get; set; } = "5.5.2";

        [JsonPropertyName("fr")]
        public int FrameRate { get; set; } = 60;

        [JsonPropertyName("ip")]
        public int InPoint { get; set; } = 0;

        [JsonPropertyName("op")]
        public int OutPoint { get; set; } = 60;

        [JsonPropertyName("w")]
        public int Width { get; set; } = 512;

        [JsonPropertyName("h")]
        public int Height { get; set; } = 512;

        [JsonPropertyName("ddd")]
        public int Is3D { get; set; } = 0;

        [JsonPropertyName("assets")]
        public List<object> Assets { get; set; } = new List<object>();

        [JsonPropertyName("layers")]
        public List<ShapeLayer> Layers { get; set; } = new List<ShapeLayer>();
    }

}
