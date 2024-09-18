// See https://aka.ms/new-console-template for more information
using LottieJsonGenerator;
using LottieJsonGenerator.Serialization;
using LottieJsonGenerator.Services;
using System.Text.Json;
using System.Text.Json.Serialization;

Console.WriteLine("Hello, World!");
// Create a PolyStar shape (Polygon with 5 points)
var polyStar = new PolyStarShape
{
    StarType = 2, // 2 for Polygon
    Position = new AnimatedPosition
    {
        Animated = 0,
        K = new List<double> { 249.313, 254.472 } // Position (249.313, 254.472)
    },
    Rotation = new AnimatedNumber
    {
        Animated = 0,
        K = 0 // Rotation at 0 degrees
    },
    Points = new AnimatedNumber
    {
        Animated = 0,
        K = 5 // Number of points
    },
    OuterRadius = new AnimatedNumber
    {
        Animated = 0,
        K = 200 // Outer radius
    },
    OuterRoundness = new AnimatedNumber
    {
        Animated = 0,
        K = 0 // Outer roundness
    },
    InnerRadius = new AnimatedNumber
    {
        Animated = 0,
        K = 100 // Inner radius (for stars)
    },
    InnerRoundness = new AnimatedNumber
    {
        Animated = 0,
        K = 0 // Inner roundness (for stars)
    }
};

// Create a new Lottie animation
var lottieAnimation = new LottieAnimation
{
    Version = "5.5.2",
    FrameRate = 60,
    InPoint = 0,
    OutPoint = 60,
    Width = 512,
    Height = 512,
    Is3D = 0,
    Assets = new List<object>(),
    Layers = new List<ShapeLayer>
                {
                    new ShapeLayer
                    {
                        Ddd = 0,
                        Index = 1,
                        Type = 4,
                        Name = "PolyStar Layer",
                        StartFrame = 1,
                        Transform = new Transform
                        {
                            AnchorPoint = new AnimatedPosition { Animated = 0, K = new List<double> { 0, 0 } },
                            Position = new AnimatedPosition { Animated = 0, K = new List<double> { 0, 0 } },
                            Scale = new AnimatedPosition { Animated = 0, K = new List<double> { 100, 100 } },
                            Rotation = new AnimatedNumber { Animated = 0, K = 0 },
                            Skew = new AnimatedNumber { Animated = 0, K = 0 },
                            SkewAxis = new AnimatedNumber { Animated = 0, K = 0 },
                            Opacity = new AnimatedNumber { Animated = 0, K = 100 }
                        },
                        Shapes = new List<Shape> { polyStar },
                        InPoint = 0,
                        OutPoint = 60,
                        StartTime = 0,
                        BlendMode = 0
                    }
                }
};

// Configure JsonSerializerOptions with the custom ShapeConverter
var options = new JsonSerializerOptions
{
    WriteIndented = true,
    Converters = { new ShapeConverter() } // Register the custom converter
};

// Serialize the Lottie animation to JSON
string jsonString = JsonSerializer.Serialize(lottieAnimation, options);

// Save the JSON to a file
File.WriteAllText("polystar_lottie_animation.json", jsonString);

Console.WriteLine("Lottie JSON created and saved as 'polystar_lottie_animation.json'!");