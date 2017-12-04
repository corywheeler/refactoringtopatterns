using NUnit.Framework;
using PolymorphicCreationWithFactoryMethod.InitialCode;

namespace RefactoringToPatterns.PolymorphicCreationWithFactoryMethod.InitialCode
{
    [TestFixture]
    public class DOMBuilderTestTests
    {
		DOMBuilderTest domBuilderTest;

		[SetUp]
		public void Init()
		{
            domBuilderTest = new DOMBuilderTest();
            domBuilderTest.TestAddAboveRoot();
        }

        [Test]
        public void test_DOMBuilderTest_has_a_DOMBuilder()
        {
            Assert.IsInstanceOf(typeof(DOMBuilder), domBuilderTest.Builder);
        }
    }
}