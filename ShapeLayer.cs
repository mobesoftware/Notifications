using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottieJsonGenerator
{
    using System.Text.Json.Serialization;
    public class ShapeLayer
    {
        [JsonPropertyName("ddd")]
        public int Ddd { get; set; } = 0;

        [JsonPropertyName("ind")]
        public int Index { get; set; }

        [JsonPropertyName("ty")]
        public int Type { get; set; } = 4; // Shape layer type

        [JsonPropertyName("nm")]
        public string Name { get; set; }

        [JsonPropertyName("sr")]
        public int StartFrame { get; set; } = 1;

        [JsonPropertyName("ks")]
        public Transform Transform { get; set; }

        [JsonPropertyName("shapes")]
        public List<Shape> Shapes { get; set; }

        [JsonPropertyName("ip")]
        public int InPoint { get; set; } = 0;

        [JsonPropertyName("op")]
        public int OutPoint { get; set; } = 60;

        [JsonPropertyName("st")]
        public int StartTime { get; set; } = 0;

        [JsonPropertyName("bm")]
        public int BlendMode { get; set; } = 0;
    }
}
