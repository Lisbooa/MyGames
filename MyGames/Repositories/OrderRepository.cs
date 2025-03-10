using MyGames.Context;
using MyGames.Models;
using MyGames.Repositories.Interfaces;

namespace MyGames.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _context;
        private readonly ShopCart _shopCart;

        public OrderRepository(AppDbContext context, ShopCart shopCart)
        {
            _context = context;
            _shopCart = shopCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderSent = DateTime.Now;
            _context.Orders.Add(order);
            _context.SaveChanges();

            var shopCartItems = _context.ShopCartItems;

            foreach(var shopItem in shopCartItems)
            {
                var OrderDetail = new OrderDetail
                {
                    Amount = shopItem.Amount,
                    GameId = shopItem.Game.GameId,
                    OrderId = order.OrderId,
                    Price = shopItem.Game.Price
                };
                _context.OrderDetails.Add(OrderDetail);
            }
            _context.SaveChanges();
        }
    }
}
