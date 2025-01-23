﻿using MyGames.Context;

namespace MyGames.Models
{
    public class ShopCart
    {
        private readonly AppDbContext _context;

        public ShopCart(AppDbContext context)
        {
            _context = context;
        }

        public string ShopCartId { get; set; }
        public List<ShopCartItem> ShopCartItems { get; set; }

        public static ShopCart GetShopCart(IServiceProvider services) 
        {
            //Define a session
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            //Obtain a service of the type of the context
            var context = services.GetService<AppDbContext>();

            //Obtain or generete an ID of ShopCart
            string shopcartId = session.GetString("ShopCartId") ?? Guid.NewGuid().ToString();

            //Assign the ID to ShopCart in Session
            session.SetString("ShopCartId", shopcartId);

            //Return the ShopCart with context and ID assigned or obtained
            return new ShopCart(context) 
            {
               ShopCartId = shopcartId,
            };
        }
    }
}
