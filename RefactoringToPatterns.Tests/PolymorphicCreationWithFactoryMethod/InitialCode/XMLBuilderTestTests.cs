using NUnit.Framework;
using PolymorphicCreationWithFactoryMethod.InitialCode;
namespace RefactoringToPatterns.PolymorphicCreationWithFactoryMethod.InitialCode
{
    [TestFixture()]
    public class XMLBuilderTestTests
    {
        XMLBuilderTest xmlBuilderTest;

		[SetUp]
		public void Init()
		{
			xmlBuilderTest = new XMLBuilderTest();
			xmlBuilderTest.TestAddAboveRoot();
		}

		[Test]
		public void test_XMLBuilderTest_has_an_XMLBuilder()
		{
			Assert.IsInstanceOf(typeof(XMLBuilder), xmlBuilderTest.Builder);
		}
    }
}