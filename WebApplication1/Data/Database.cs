using WebApplication1.Models;
using WebApplication1.Services.Builders;

namespace WebApplication1.Data
{
    public class Database
    {
        private List<Buyer> _buyers;
        private List<Property> _properties;
        private List<Feature> _features;

        public void Initialize()
        {
            InitializeFeatures();
            InitializeBuyers();
            InitializeProperties();
        }

        private void InitializeBuyers()
        {
            _buyers = new List<Buyer>()
            {
                BuyerBuilder.ABuyer()
                .WithId("buyer1")
                .WithName("buyer1")
                .WithFeatures(new []
                {
                    FeatureBuilder.AClonedFeature(_features[0]).WithScore(6).Build(),
                    FeatureBuilder.AClonedFeature(_features[3]).WithScore(7).Build(),
                    FeatureBuilder.AClonedFeature(_features[4]).WithScore(9).Build()
                })
                .Build(),
                BuyerBuilder.ABuyer()
                .WithId("buyer2")
                .WithName("buyer2")
                .WithFeatures(new []
                {
                    FeatureBuilder.AClonedFeature(_features[1]).WithScore(4).Build(),
                    FeatureBuilder.AClonedFeature(_features[2]).WithScore(5).Build(),
                    FeatureBuilder.AClonedFeature(_features[4]).WithScore(4).Build()
                })
                .Build(),
                BuyerBuilder.ABuyer()
                .WithId("buyer3")
                .WithName("buyer3")
                .WithFeatures(new []
                {
                    FeatureBuilder.AClonedFeature(_features[0]).WithScore(7).Build(),
                    FeatureBuilder.AClonedFeature(_features[1]).WithScore(8).Build(),
                    FeatureBuilder.AClonedFeature(_features[3]).WithScore(7).Build(),
                    FeatureBuilder.AClonedFeature(_features[4]).WithScore(9).Build()
                })
                .Build(),
            };
        }

        private void InitializeProperties()
        {
            _properties = new List<Property>()
            {
                PropertyBuilder.AProperty()
                .WithId("property1")
                .WithDescription("property1")
                .WithFeatures(new []
                {
                    FeatureBuilder.AClonedFeature(_features[0]).WithScore(6).Build(),
                    FeatureBuilder.AClonedFeature(_features[3]).WithScore(7).Build(),
                    FeatureBuilder.AClonedFeature(_features[4]).WithScore(9).Build()
                })
                .Build(),
                PropertyBuilder.AProperty()
                .WithId("property2")
                .WithDescription("property2")
                .WithFeatures(new []
                {
                    FeatureBuilder.AClonedFeature(_features[1]).WithScore(4).Build(),
                    FeatureBuilder.AClonedFeature(_features[2]).WithScore(5).Build(),
                    FeatureBuilder.AClonedFeature(_features[4]).WithScore(4).Build()
                })
                .Build(),
                PropertyBuilder.AProperty()
                .WithId("property3")
                .WithDescription("property3")
                .WithFeatures(new []
                {
                    FeatureBuilder.AClonedFeature(_features[0]).WithScore(7).Build(),
                    FeatureBuilder.AClonedFeature(_features[1]).WithScore(8).Build(),
                    FeatureBuilder.AClonedFeature(_features[3]).WithScore(7).Build(),
                    FeatureBuilder.AClonedFeature(_features[4]).WithScore(9).Build()
                })
                .Build(),
            };
        }
        private void InitializeFeatures()
        {
            _features = new List<Feature>()
            {
                FeatureBuilder.AFeature().WithId("1").Build(),
                FeatureBuilder.AFeature().WithId("2").Build(),
                FeatureBuilder.AFeature().WithId("3").Build(),
                FeatureBuilder.AFeature().WithId("4").Build(),
                FeatureBuilder.AFeature().WithId("5").Build(),
            };
        }
    }
}
