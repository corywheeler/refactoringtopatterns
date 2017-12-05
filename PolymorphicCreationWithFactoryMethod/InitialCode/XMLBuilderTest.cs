namespace PolymorphicCreationWithFactoryMethod.InitialCode
{
    public class XMLBuilderTest: TestCase
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

			Builder = new XMLBuilder("orders");

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