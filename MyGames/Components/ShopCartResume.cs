using Microsoft.AspNetCore.Mvc;
using MyGames.Models;
using MyGames.ViewModels;

namespace MyGames.Components
{
    public class ShopCartResume : ViewComponent
    {
        private readonly ShopCart _shopCart;

        public ShopCartResume(ShopCart shopCart)
        {
            _shopCart = shopCart;
        }

        public IViewComponentResult Invoke() 
        {
            var items = _shopCart.GetShopCartItems();
            //var items = new List<ShopCartItem>() 
            //{
            //    new ShopCartItem(),
            //    new ShopCartItem()
            //};
            _shopCart.ShopCartItems = items;

            var shopCartVM = new ShopCartViewModel
            {
                ShopCart = _shopCart,
                ShopCartTotal = _shopCart.GetShopCartTotal()
            };
            return View(shopCartVM);
        } 
    }
}
