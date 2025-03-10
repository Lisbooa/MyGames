using MyGames.Models;

namespace MyGames.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
