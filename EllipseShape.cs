using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottieJsonGenerator
{
    using System.Text.Json.Serialization;

    public class EllipseShape : Shape
    {
        public EllipseShape()
        {
            Type = "el"; // Ellipse type
            Name = "Ellipse";
        }

        [JsonPropertyName("p")]
        public Position Position { get; set; }

        [JsonPropertyName("s")]
        public Size Size { get; set; }
    }

}
