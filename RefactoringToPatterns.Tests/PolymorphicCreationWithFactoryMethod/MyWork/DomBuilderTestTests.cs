using NUnit.Framework;
using PolymorphicCreationWithFactoryMethod.MyWork;

namespace RefactoringToPatterns.PolymorphicCreationWithFactoryMethod.MyWork
{
    [TestFixture]
    public class DOMBuilderTestTests
    {
		DOMBuilderTest _domBuilderTest;

		[SetUp]
		public void Init()
		{
            _domBuilderTest = new DOMBuilderTest();
            _domBuilderTest.TestAddAboveRoot();
        }

        [Test]
        public void test_DOMBuilderTest_has_a_DOMBuilder()
        {
            Assert.IsInstanceOf(typeof(DOMBuilder), _domBuilderTest.Builder);
        }
    }
}