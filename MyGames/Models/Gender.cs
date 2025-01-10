namespace MyGames.Models
{
    public class Gender
    {
        public int GenderId { get; set; }
        public string GenderName { get; set; }
        public string Description { get; set; }

        public List<Game> Games { get; set; }
    }
}
