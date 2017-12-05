namespace PolymorphicCreationWithFactoryMethod.MyWork
{
    public class DOMBuilderTest: AbstractBuilderTest
    {
        public OutputBuilder Builder { get; private set; }

        protected OutputBuilder CreateBuilder(string rootName)
        {
            return new DOMBuilder(rootName);
        }

        public void TestAddAboveRoot()
        {
            string invalidResult =
                "<orders>" +
                    "<order>" +
                    "</order>" +
                "</orders>" +
                "<customer>" +
                "</customer>";

            Builder = CreateBuilder("orders");

            Builder.AddBelow("order");

            try
            {
                Builder.AddAbove("customer");
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
