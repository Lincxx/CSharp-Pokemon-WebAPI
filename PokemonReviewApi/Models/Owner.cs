namespace PokemonReviewApi.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public String Gym { get; set; }
        // 1 to 1
        public Country Country { get; set; }
        //many to many
        public ICollection<PokemonOwner> PokemonOwners { get; set; }
    }
}
