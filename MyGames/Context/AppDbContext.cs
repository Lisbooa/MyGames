using MyGames.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace MyGames.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        }

        public DbSet<Genre> Genders { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<ShopCartItem> ShopCartItems { get; set; }
    }
}
