using System.Collections.Generic;

namespace ExtractComposite.MyWork
{
    public abstract class CompositeTag: Tag
    {
        protected readonly List<Node> _nodeList = new List<Node>();
        
        protected CompositeTag(string openingTag, string closingTag) : base(openingTag, closingTag)
        {
        }
    }
}