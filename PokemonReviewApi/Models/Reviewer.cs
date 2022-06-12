namespace PokemonReviewApi.Models
{
    public class Reviewer
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public string LastName { get; set; }
        // 1 to many
        public ICollection<Review> Reviews { get; set; }
    }
}
