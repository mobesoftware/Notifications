using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottieJsonGenerator
{
    using System.Text.Json.Serialization;

    public abstract class Shape
    {
        [JsonPropertyName("ty")]
        public string Type { get; set; }

        [JsonPropertyName("nm")]
        public string Name { get; set; }
    }

}
