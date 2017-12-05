using NUnit.Framework;
using PolymorphicCreationWithFactoryMethod.MyWork;

namespace RefactoringToPatterns.PolymorphicCreationWithFactoryMethod.MyWork
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