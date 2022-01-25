namespace ExtractComposite.InitialCode
{
    public class Tag : Node
    {
        protected string _openingTag = string.Empty;
        protected string _closingTag= string.Empty;

        protected Tag(string openingTag, string closingTag)
        {
            _openingTag = openingTag;
            _closingTag = closingTag;
        }
        
        public override string ToPlainTextString()
        {
            return string.Empty;
        }
    }
}