using System.Collections.Generic;

namespace ExtractComposite.InitialCode
{
    public class LinkTag: Tag
    {
        private readonly List<Node> _nodeList = new List<Node>();

        public LinkTag()
        {
            _openingTag = "<A HREF=_>";
            _closingTag = "</A>";
        }
        
        public override string ToPlainTextString()
        {
            
            var buffer = string.Empty;
            LinkData().ForEach(node => buffer += node.ToPlainTextString());
            return buffer;
        }

        public void AddChild(Node child)
        {
            _nodeList.Add(child);
        }

        private List<Node> LinkData()
        {
            return _nodeList;
        }
    }
}