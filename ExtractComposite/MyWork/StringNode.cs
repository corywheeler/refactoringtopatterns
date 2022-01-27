namespace ExtractComposite.MyWork
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