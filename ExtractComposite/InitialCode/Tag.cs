using System;

namespace ExtractComposite.InitialCode
{
    public class Tag : Node
    {
        protected string _openingTag;
        protected string _closingTag;

        public Tag()
        {
            _openingTag = string.Empty;
            _closingTag = string.Empty;
        }
        
        public override string ToPlainTextString()
        {
            return string.Empty;
        }
    }
}