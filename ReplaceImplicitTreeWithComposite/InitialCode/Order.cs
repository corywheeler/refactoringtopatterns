using System.Collections.Generic;

namespace ReplaceImplicitTreeWithComposite.InitialCode
{
    public class Order
    {
        private readonly int id;
        private List<Product> products;

        public Order(int id)
        {
            this.products = new List<Product>();
            this.id = id;
        }

        public int OrderId()
        {
            return this.id;
        }

        public void Add(Product product)
        {
            this.products.Add(product);
        }

        public int ProductCount()
        {
            return this.products.Count;
        }

        public Product Product(int insertionIndex)
        {
            return this.products[insertionIndex];
        }
    }
}