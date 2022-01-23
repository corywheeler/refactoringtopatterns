using System.Threading;

namespace ExtractComposite.InitialCode
{
    public class StringNode : Node
    {
        private readonly string _text;

        public StringNode(string text)
        {
            this._text = text;
        }

        public override string ToPlainTextString()
        {
            return _text;
        }
    }
}