using Final_Project.Models;

namespace Final_Project.Repositories
{
    public interface IOrderRepository : IRepository<Order>
    {
        // Additional methods specific to orders
        void AddOrderWithItems(Order order, List<OrderItem> orderItems);
    }
}