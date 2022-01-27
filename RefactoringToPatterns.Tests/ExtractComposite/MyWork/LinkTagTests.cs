using ExtractComposite.MyWork;
using NUnit.Framework;

namespace RefactoringToPatterns.ExtractComposite.MyWork
{
    [TestFixture]
    public class LinkTagTests
    {
        LinkTag _linkTag;

        [SetUp]
        public void Init()
        {
            _linkTag = new LinkTag();
        }

        [Test]
        public void it_should_output_a_non_html_formatted_text_representation()
        {
            _linkTag.AddChild(new StringNode("Hi, I'm Link."));
            _linkTag.AddChild(new StringNode("My text becomes a link!"));

            Assert.AreEqual("Hi, I'm Link.My text becomes a link!",_linkTag.ToPlainTextString());
        }
        
    }
}