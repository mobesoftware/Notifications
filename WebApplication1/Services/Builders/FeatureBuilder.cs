using WebApplication1.Models;

namespace WebApplication1.Services.Builders
{
    public class FeatureBuilder
    {
        private Feature _feature;

        public static FeatureBuilder AFeature()
        {
            return new FeatureBuilder { _feature = new Feature() };
        }
        public static FeatureBuilder AClonedFeature(Feature feature)
        {
            return new FeatureBuilder { _feature = feature.Clone() };
        }
        public FeatureBuilder WithId(string id)
        {
            _feature.Id = id;
            return this;
        }
        public FeatureBuilder WithScore(int score)
        {
            _feature.Score = score;
            return this;
        }

        public Feature Build()
        {
            return _feature;
        }
    }
}
