namespace ExtractComposite.MyWork
{
    public class LabelTag: Tag 
    {
        private StringNode _labelText;
        public LabelTag(StringNode labelText): base("<label>","</label>")
        {
            _labelText = labelText;
        }

        public override string ToPlainTextString()
        {
            return _labelText.ToPlainTextString();
        }
    }
}