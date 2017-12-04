using NUnit.Framework;
using PolymorphicCreationWithFactoryMethod.InitialCode;
namespace RefactoringToPatterns.PolymorphicCreationWithFactoryMethod.InitialCode
{
    [TestFixture()]
    public class XMLBuilderTestTests
    {
        XMLBuilderTest _xmlBuilderTest;

		[SetUp]
		public void Init()
		{
			_xmlBuilderTest = new XMLBuilderTest();
			_xmlBuilderTest.TestAddAboveRoot();
		}

		[Test]
		public void test_XMLBuilderTest_has_an_XMLBuilder()
		{
			Assert.IsInstanceOf(typeof(XMLBuilder), _xmlBuilderTest.Builder);
		}
    }
}