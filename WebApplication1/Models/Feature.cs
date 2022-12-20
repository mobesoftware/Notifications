namespace WebApplication1.Models
{
    public class Feature
    {
        public string Id { get; set; }
        public int Score { get; set; }

        public Feature Clone()
        {
            return new Feature { Id = Id, Score = Score };
        }
    }
}
