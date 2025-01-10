namespace MyGames.Models
{
    public class Game
    {
        public int GameId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string DetailedDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool Available { get; set; }

        public int GenderId { get; set; }
        public virtual Gender Gender { get; set; }
    }
}
