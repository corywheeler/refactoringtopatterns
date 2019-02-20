using NUnit.Framework;
using ReplaceImplicitTreeWithComposite.MyWork;

namespace RefactoringToPatterns.ReplaceImplicitTreeWithComposite.MyWork
{
    [TestFixture]
    public class TagTests
    {
        private const string SamplePrice = "2.39";

        [Test]
        public void TestSimpleTagWithOneAttributeAndValue()
        {
            var expected =
                "<price currency=" +
                "'" +
                "USD" +
                "'>" +
                SamplePrice +
                "</price>";

            TagNode priceTag = new TagNode("price");
            priceTag.AddAttribute("currency", "USD");
            priceTag.AddValue(SamplePrice);
            Assert.AreEqual(expected, priceTag.ToString());
        }
    }
}
