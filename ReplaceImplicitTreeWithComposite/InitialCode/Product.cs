namespace ReplaceImplicitTreeWithComposite.InitialCode
{
    public class Product
    {
        public Product(int id, string name, ProductSize size, string price)
        {
            this.ID = id;
            this.Name = name;
            this.Size = size;
            this.Price = price;
        }

        public int ID { get; }

        public string Name { get; }

        public ProductSize Size { get;  }

        public string Price { get; }

    }
}