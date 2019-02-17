using System.Collections.Generic;

namespace ReplaceImplicitTreeWithComposite.InitialCode
{
    public class Orders
    {
        private List<Order> _orders;

        public Orders()
        {
            _orders = new List<Order>();
        }

        public void Add(Order order)
        {
            _orders.Add(order);

        }

        public int OrderCount()
        {
            return _orders.Count;
        }

        public Order Order(int insertionIndex)
        {
            return _orders[insertionIndex];
        }
    }
}