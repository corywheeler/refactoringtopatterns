using System.Text;
namespace ReplaceImplicitTreeWithComposite.InitialCode
{
    public class OrdersWriter
    {
        private Orders _orders;

        public OrdersWriter(Orders orders)
        {
            _orders = orders;
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
            for(int i = 0; i < _orders.OrderCount(); i++)
            {
                Order order = _orders.Order(i);
                xml.Append("<order");
                xml.Append(" id='");
                xml.Append(order.OrderId());
                xml.Append("'>");
                WriteProducts(xml, order);
                xml.Append("</order>");
            }
            xml.Append("</orders>");
        }

        private void WriteProducts(StringBuilder xml, Order order)
        {
            for(int j = 0; j < order.ProductCount(); j++)
            {
                Product product = order.Product(j);
                xml.Append("<product");
                xml.Append(" id='");
                xml.Append(product.ID);
                xml.Append("'");
                xml.Append(" color='");
                xml.Append(ColorFor(product));
                xml.Append("'");
                if (product.Size != (int)ProductSize.NOT_APPLICABLE)
                {
                    xml.Append(" size='");
                    xml.Append(SizeFor(product));
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
            xml.Append(CurrencyFor(product));
            xml.Append("'>");
            xml.Append(product.Price);
            xml.Append("</price>");
        }

        private string CurrencyFor(Product product)
        {
            // I made all products in USD for this example
            return "USD";
        }

        private string SizeFor(Product product)
        {
            switch (product.Size)
            {
                case ProductSize.MEDIUM:
                    return "medium";
                default:
                    return "NOT APPLICABLE";
            }
        }

        private string ColorFor(Product product)
        {
            // I have made all products red for this example
            return "red";
        }
    }
}
