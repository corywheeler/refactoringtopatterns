using ExtractComposite.MyWork;
using NUnit.Framework;

namespace RefactoringToPatterns.ExtractComposite.MyWork
{
    [TestFixture]
    public class LabelTagTests
    {
        private LabelTag _labelTag;
        
        [SetUp]
        public void Init()
        {
            _labelTag = new LabelTag(new StringNode("Name:"));
        }

        [Test]
        public void it_should_output_a_non_html_formatted_text_representation()
        {
            Assert.AreEqual("Name:", _labelTag.ToPlainTextString());
        }
    }
}