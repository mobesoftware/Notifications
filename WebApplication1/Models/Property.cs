namespace WebApplication1.Models
{
    public class Property
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public IEnumerable<Feature> Feautures { get; set; }
    }
}
