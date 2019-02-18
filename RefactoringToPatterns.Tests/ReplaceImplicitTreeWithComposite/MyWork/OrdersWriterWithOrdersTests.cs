using NUnit.Framework;
using ReplaceImplicitTreeWithComposite.MyWork;

namespace RefactoringToPatterns.ReplaceImplicitTreeWithComposite.MyWork
{
    [TestFixture()]
    public class OrdersWriterWithOrdersTests
    {
        private OrdersWriter ordersWriter;

        [SetUp]
        public void Init()
        {
            var orders = new Orders();
            var order = new Order(1234);
            order.Add(new Product(4321, "T-Shirt", ProductSize.Medium, "21.00"));
            order.Add(new Product(6789, "Socks", ProductSize.Medium, "8.00"));
            orders.Add(order);

            this.ordersWriter = new OrdersWriter(orders);
        }

        [Test]
        public void GetContents_produces_all_orders()
        {
            var expectedOrder =
            "<orders>" + 
                "<order id='1234'>" + 
                    "<product id='4321' color='red' size='medium'>" + 
                        "<price currency='USD'>" + 
                        "21.00" + 
                        "</price>" + 
                    "T-Shirt" + 
                    "</product>" + 
                    "<product id='6789' color='red' size='medium'>" + 
                        "<price currency='USD'>" + 
                        "8.00" + 
                        "</price>" + 
                    "Socks" + 
                    "</product>" + 
                "</order>" + 
            "</orders>";
            Assert.AreEqual(expectedOrder, this.ordersWriter.GetContents());
        }
    }

    [TestFixture]
    public class OrdersWriterWithNoOrdersTests
    {
        private OrdersWriter ordersWriter;

        [SetUp]
        public void Init()
        {
            var orders = new Orders();
            this.ordersWriter = new OrdersWriter(orders);
        }

        [Test]
        public void GetContents_produces_no_orders()
        {
            var expectedOrder = 
            "<orders>" + 
            "</orders>";

            Assert.AreEqual(expectedOrder, this.ordersWriter.GetContents());
        }
    }
}