using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ExtractComposite.InitialCode
{
    public class FormTag: Tag
    {
        private readonly List<Tag> _nodeList = new List<Tag>();

        public FormTag() : base("<form>", "</form>")
        {
            
        }
        
        
        public void AddChild(Tag tag)
        {
            _nodeList.Add(tag);
        }

        public string ToPlainTextString()
        {
            var stringRepresentation = string.Empty;
            GetAllNodes().ForEach(node => stringRepresentation += node.ToPlainTextString());
            return stringRepresentation;
        }

        private List<Tag> GetAllNodes()
        {
            return _nodeList;
        }
    }
}