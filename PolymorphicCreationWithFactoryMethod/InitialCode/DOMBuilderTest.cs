namespace PolymorphicCreationWithFactoryMethod.InitialCode
{
    public class DOMBuilderTest : TestCase
    {
        private OutputBuilder builder;

        public OutputBuilder Builder { get => builder; private set => builder = value; }

        public void TestAddAboveRoot()
        {
            string invalidResult =
                "<orders>" +
                    "<order>" +
                    "</order>" +
                "</orders>" +
                "<customer>" +
                "</customer>";

            builder = new DOMBuilder();

            builder.AddBelow("order");

            try
            {
                builder.AddAbove("customer");
                Fail("expecting RuntimeException");
            }
            catch (RuntimeException ignored)
            {

            }
        }

        private void Fail(string failureMessage)
        {

        }
    }
}
