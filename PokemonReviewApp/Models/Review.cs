namespace PokemonReviewApp.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }

        public int pokimonId { get; set; }
        public Pokimon? pokimon { get; set; }

        public int reviewerId { get; set; }
        public Reviewer? reviewer { get; set; }
    }
}
