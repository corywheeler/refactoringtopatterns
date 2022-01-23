using System.Collections.Generic;

namespace ExtractComposite.InitialCode
{
    public class FormTag
    {
        private readonly List<Tag> _nodeList = new List<Tag>();
        public void AddChild(Tag tag)
        {
            _nodeList.Add(tag);
        }

        public string ToPlainTextString()
        {
            var stringRepresentation = string.Empty;
            GetAllNodes().ForEach(node => stringRepresentation += node.ToString());
            return stringRepresentation;
        }

        private List<Tag> GetAllNodes()
        {
            return _nodeList;
        }
    }
}