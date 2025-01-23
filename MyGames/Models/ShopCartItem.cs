using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyGames.Models
{
    [Table("ShopCartItems")]
    public class ShopCartItem
    {
        public int ShopCartItemId { get; set; }
        public Game Game { get; set; }
        public int Amount { get; set; }

        [StringLength(200)]
        public string ShopCartId { get; set; }
    }
}
