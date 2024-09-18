using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LottieJsonGenerator
{
    // Keyframe class with bezier tangents and easing handles
    public class Keyframe
    {
        [JsonPropertyName("t")]
        public int Time { get; set; } // Frame number (in frames)

        [JsonPropertyName("s")]
        public List<double> StartValue { get; set; } // Starting value of the keyframe

        [JsonPropertyName("e")]
        public List<double> EndValue { get; set; } // End value (optional)

        [JsonPropertyName("i")]
        public EasingHandle InTangent { get; set; } = new EasingHandle
        {
            X = new List<double> { 1, 1 }, // Default linear easing
            Y = new List<double> { 1, 1 }
        };

        [JsonPropertyName("o")]
        public EasingHandle OutTangent { get; set; } = new EasingHandle
        {
            X = new List<double> { 0, 0 }, // Default linear easing
            Y = new List<double> { 0, 0 }
        };

        [JsonPropertyName("ti")]
        public List<double> TangentIn { get; set; } = new List<double> { 0, 0 }; // Tangent in values

        [JsonPropertyName("to")]
        public List<double> TangentOut { get; set; } = new List<double> { 0, 0 }; // Tangent out values

        [JsonPropertyName("h")]
        public int Hold { get; set; } = 0; // Whether it's a hold frame (0 = no, 1 = yes)
    }

}
