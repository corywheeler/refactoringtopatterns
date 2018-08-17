using System.Text;
using MoveEmbellishmentToDecorator.InitialCode;
using NUnit.Framework;

namespace RefactoringToPatterns.Tests.MoveEmbellishmentToDecorator.InitialCode
{
    [TestFixture()]
    public class StringNodeTests
    {
        [Test()]
        public void testDecodingAmpersand()
        {
            string ENCODED_WORKSHOP_TITLE = "The Testing &amp; Refactoring Workshop";
            string DECODED_WORKSHOP_TITLE = "The Testing & Refactoring Workshop";

            StringBuilder decodedContent = new StringBuilder();
            Parser parser = Parser.createParser(ENCODED_WORKSHOP_TITLE);
            parser.setNodeDecoding(true);
            NodeIterator nodes = parser.element();

            while (nodes.hasMoreNodes())
                decodedContent.Append(nodes.nextNode().toPlainTextString());

            Assert.AreEqual(DECODED_WORKSHOP_TITLE, decodedContent.ToString(), "ampersand in string");
        }
    }
}