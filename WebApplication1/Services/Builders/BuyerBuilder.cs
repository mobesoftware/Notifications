using WebApplication1.Models;

namespace WebApplication1.Services.Builders
{
    public class BuyerBuilder
    {
        private Buyer _buyer;

        public static BuyerBuilder ABuyer()
        {
            return new BuyerBuilder { _buyer = new Buyer() };
        }
        public BuyerBuilder WithId(string id)
        {
            _buyer.Id = id;
            return this;
        }
        public BuyerBuilder WithName(string name)
        {
            _buyer.Name = name;
            return this;
        }
        public BuyerBuilder WithFeatures(IEnumerable<Feature> features)
        {
            _buyer.Feautures = features;
            return this;
        }

        public Buyer Build()
        {
            return _buyer;
        }
    }
}
