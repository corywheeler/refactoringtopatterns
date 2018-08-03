using System.Collections.Generic;
using System.Text;

namespace MoveEmbellishmentToDecorator.MyWork
{
    public class Parser
    {
        private bool _shouldDecodeNodes = false;
        private string _stringContent;

        public bool shouldDecodeNodes()
        {
            return this._shouldDecodeNodes;
        }

        public void setNodeDecoding(bool shouldDecodeNodes)
        {
            this._shouldDecodeNodes = shouldDecodeNodes;
        }

        public static Parser createParser(string stringContent)
        {
            return new Parser()
            {
                _stringContent = stringContent
            };
        }

        public NodeIterator element()
        {
            StringBuilder decodedContent = new StringBuilder();
            decodedContent.Append(_stringContent);
            return new NodeIterator(new List<Node>{new StringNode(decodedContent, 0, 0, true)});
        }
    }
}