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
            WriteOrderTo(xml);
            return xml.ToString();
        }

        private void WriteOrderTo(StringBuilder xml)
        {
            xml.Append("<orders>");
            for (int i = 0; i < this.orders.OrderCount(); i++)
            {
                Order order = this.orders.Order(i);
                xml.Append("<order");
                xml.Append(" id='");
                xml.Append(order.OrderId());
                xml.Append("'>");
                WriteProductsTo(xml, order);

                xml.Append("</order>");
            }

            xml.Append("</orders>");
        }

        private void WriteProductsTo(StringBuilder xml, Order order)
        {
            for (int j = 0; j < order.ProductCount(); j++)
            {
                Product product = order.Product(j);
                xml.Append("<product");
                xml.Append(" id='");
                xml.Append(product.ID);
                xml.Append("'");
                xml.Append(" color='");
                xml.Append(this.ColorFor(product));
                xml.Append("'");
                if (product.Size != (int)ProductSize.NotApplicable)
                {
                    xml.Append(" size='");
                    xml.Append(this.SizeFor(product));
                    xml.Append("'");
                }

                xml.Append(">");
                WritePriceTo(xml, product);
                xml.Append(product.Name);
                xml.Append("</product>");
            }
        }

        private void WritePriceTo(StringBuilder xml, Product product)
        {
            xml.Append("<price");
            xml.Append(" currency='");
            xml.Append(this.CurrencyFor(product));
            xml.Append("'>");
            xml.Append(product.Price);
            xml.Append("</price>");
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