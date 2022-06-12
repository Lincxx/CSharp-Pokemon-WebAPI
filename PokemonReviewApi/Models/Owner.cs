namespace PokemonReviewApi.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Gym { get; set; }
        // 1 to 1
        public Country Country { get; set; }
        
    }
}
