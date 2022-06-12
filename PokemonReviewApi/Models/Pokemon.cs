namespace PokemonReviewApi.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public DateTime BirthDate { get; set; }

        //ICollection is a list that is immutable and less function
        // 1 to many
        public ICollection<Review> Reviews { get; set; }
    }
}
