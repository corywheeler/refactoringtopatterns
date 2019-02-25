using NUnit.Framework;
using EncapsulateCompositeWithBuilder.MyWork;

namespace RefactoringToPatterns.EncapsulateCompositeWithBuilder.MyWork
{
    [TestFixture]
    public class TagBuilderTest
    {
        [Test]
        public void TestBuildOneNode()
        {
            string expectedXml = "<flavors/>";

            string actualXml = new TagBuilder("flavors").ToXml();

            Assert.AreEqual(expectedXml, actualXml);
        }
    }
}
