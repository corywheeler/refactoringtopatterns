namespace ReplaceImplicitTreeWithComposite.InitialCode
{
    public class Product
    {
        public Product(int id, string name, ProductSize size, string price)
        {
            ID = id;
            Name = name;
            Size = size;
            Price = price;
        }

        public int ID { get; }
        public string Name { get; }
        public ProductSize Size { get;  }
        public string Price { get; }
    }
}