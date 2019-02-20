using System.Text;

namespace ReplaceImplicitTreeWithComposite.MyWork
{
    public class OrdersWriter
    {
        private Orders orders;

        public OrdersWriter(Orders orders)
        {
            this.orders = orders;
        }

        public string GetContents()
        {
            StringBuilder xml = new StringBuilder();
            this.WriteOrderTo(xml);
            return xml.ToString();
        }

        private void WriteOrderTo(StringBuilder xml)
        {
            TagNode ordersTag = new TagNode("orders");

            for (int i = 0; i < this.orders.OrderCount(); i++)
            {
                Order order = this.orders.Order(i);
                TagNode orderTag = new TagNode("order");
                orderTag.AddAttribute("id", order.OrderId().ToString());

                this.WriteProductsTo(orderTag, order);

                ordersTag.Add(orderTag);
            }

            xml.Append(ordersTag.ToString());
        }

        private void WriteProductsTo(TagNode orderTag, Order order)
        {
            for (int j = 0; j < order.ProductCount(); j++)
            {
                Product product = order.Product(j);
                TagNode productTag = new TagNode("product");
                productTag.AddAttribute("id", product.ID.ToString());
                productTag.AddAttribute("color", this.ColorFor(product));
                if (product.Size != (int)ProductSize.NotApplicable)
                {
                    productTag.AddAttribute("size", this.SizeFor(product));
                }

                this.WritePriceTo(productTag, product);

                productTag.AddValue(product.Name);
                orderTag.Add(productTag);
            }
        }

        private void WritePriceTo(TagNode productTag, Product product)
        {
            TagNode priceNode = new TagNode("price");
            priceNode.AddAttribute("currency", this.CurrencyFor(product));
            priceNode.AddValue(product.Price);
            productTag.Add(priceNode);
        }

        private string CurrencyFor(Product product)
        {
            // I made the assumption that all products will be in USD for 
            // this example
            return "USD";
        }

        private string SizeFor(Product product)
        {
            // I've made the assumption that all sizes will be a medium
            // for this example
            switch (product.Size)
            {
                case ProductSize.Medium:
                    return "medium";
                default:
                    return "NOT APPLICABLE";
            }
        }

        private string ColorFor(Product product)
        {
            // I made the assumption that all products are red for this example
            return "red";
        }
    }
}