using System;
using System.Text;

namespace MoveEmbellishmentToDecorator.MyWork
{
    public class StringNode : AbstractNode
    {
        private StringBuilder textBuilder;
        private bool shouldDecode;

        public StringNode(StringBuilder textBuffer, int textBegin, int textEnd) : base(textBegin, textEnd)
        {
            this.textBuilder = textBuffer;
        }

        public StringNode(StringBuilder textBuffer, int textBegin, int textEnd, bool shouldDecode) : this(textBuffer, textBegin, textEnd)
        {
            this.shouldDecode = shouldDecode;
        }

        public override string toHtml()
        {
            throw new NotImplementedException();
        }

        public override string toPlainTextString()
        {
            string result = textBuilder.ToString();
            if (shouldDecode)
                result = Translate.decode(result);
            return result;
        }
    }
}