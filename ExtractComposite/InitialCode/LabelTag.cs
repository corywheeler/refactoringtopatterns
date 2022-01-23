namespace ExtractComposite.InitialCode
{
    public class LabelTag : Tag
    {
        private StringNode _labelText;
        public LabelTag(StringNode labelText)
        {
            _labelText = labelText;
        }

        public override string ToString()
        {
            return _labelText.ToPlainTextString();
        }
    }
}