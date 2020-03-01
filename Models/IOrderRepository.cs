using System.Collections.Generic;

namespace SportStore.Models
{
    public class IOrderRepository
    {
        IEnumerable<Order> Orders { get; }
        void SaveOrder(Order order);
    }
}
