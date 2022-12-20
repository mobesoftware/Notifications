namespace WebApplication1.Models
{
    public class Buyer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Feature> Feautures { get; set; }
    }
}
