namespace PolymorphicCreationWithFactoryMethod.MyWork
{
    public class XMLBuilderTest: TestCase
    {
        public OutputBuilder Builder { get; private set; }

        protected OutputBuilder CreateBuilder(string rootName)
        {
            return new XMLBuilder(rootName);
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