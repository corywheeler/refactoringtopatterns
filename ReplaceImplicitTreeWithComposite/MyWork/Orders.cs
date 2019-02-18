using System.Collections.Generic;

namespace ReplaceImplicitTreeWithComposite.MyWork
{

    public class Orders
    {
        private List<Order> orders;

        public Orders()
        {
            this.orders = new List<Order>();
        }

        public void Add(Order order)
        {
            this.orders.Add(order);
        }

        public int OrderCount()
        {
            return this.orders.Count;
        }

        public Order Order(int insertionIndex)
        {
            return this.orders[insertionIndex];
        }
    }
}