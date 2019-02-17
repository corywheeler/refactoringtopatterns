using System.Collections.Generic;

namespace ReplaceImplicitTreeWithComposite.InitialCode
{
    public class Order
    {
        private readonly int _id;
        private List<Product> _products;

        public Order(int id)
        {
            _products = new List<Product>();
            _id = id;
        }

        public int OrderId()
        {
            return _id;
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public int ProductCount()
        {
            return _products.Count;
        }

        public Product Product(int insertionIndex)
        {
            return _products[insertionIndex];
        }
    }
}