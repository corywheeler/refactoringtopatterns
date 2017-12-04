namespace PolymorphicCreationWithFactoryMethod.InitialCode
{
    public class DOMBuilderTest: TestCase
    {
        public OutputBuilder Builder { get; private set; }

        public void TestAddAboveRoot()
        {
            string invalidResult =
                "<orders>" +
                    "<order>" +
                    "</order>" +
                "</orders>" +
                "<customer>" +
                "</customer>";

            Builder = new DOMBuilder();

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
