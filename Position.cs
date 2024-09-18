using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LottieJsonGenerator
{
    public class Position
    {
        [JsonPropertyName("a")]
        public int Animated { get; set; } = 0; // 0 = static, 1 = animated

        // Static position or a list of keyframes if animated
        [JsonPropertyName("k")]
        public object K { get; set; } 
        //    = new List<Keyframe>
        //{
        //    new Keyframe
        //    {
        //        Time = 0,
        //        StartValue = new List<double> { 256, 256 },
        //        EndValue = new List<double> { 256, 256 },
        //        TangentIn = new List<double> { 0, 0 },
        //        TangentOut = new List<double> { 0, 0 },
        //        InTangent = new EasingHandle { X = new List<double> { 1, 1 }, Y = new List<double> { 1, 1 } },
        //        OutTangent = new EasingHandle { X = new List<double> { 0, 0 }, Y = new List<double> { 0, 0 } },
        //        Hold = 0
        //    }
        //};

        [JsonPropertyName("x")]
        public string Expression { get; set; } // Optional expression property for dynamic calculations

        // Method to set animated position
        public void SetAnimatedPosition(object keyframes)
        {
            Animated = 1;
            K = keyframes;
        }
    }
}
