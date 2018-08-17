using System.Text;

namespace MoveEmbellishmentToDecorator.InitialCode
{
    public class StringParser
    {
        private StringBuilder textBuffer;
        private int textBegin;
        private int textEnd;

        public Node find(NodeReader reader, string input, string position, bool balance_quotes)
        {
            return new StringNode(textBuffer, textBegin, textEnd, reader.getParser().shouldDecodeNodes());
        }
    }
}
