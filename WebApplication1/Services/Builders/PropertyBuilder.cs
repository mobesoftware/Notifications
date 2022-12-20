using WebApplication1.Models;

namespace WebApplication1.Services.Builders
{
    public class PropertyBuilder
    {
        private Property _property;

        public static PropertyBuilder AProperty()
        {
            return new PropertyBuilder { _property = new Property() };
        }
        public PropertyBuilder WithId(string id)
        {
            _property.Id = id;
            return this;
        }
        public PropertyBuilder WithDescription(string description)
        {
            _property.Description = description;
            return this;
        }
        public PropertyBuilder WithFeatures(IEnumerable<Feature> features)
        {
            _property.Feautures = features;
            return this;
        }

        public Property Build()
        {
            return _property;
        }
    }
}
