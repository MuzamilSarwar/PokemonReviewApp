using System.Security.Cryptography;

namespace PokemonReviewApp.Models
{
    public class Pokimon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        public ICollection<Review> Reviews { get; set; }

    }
}
