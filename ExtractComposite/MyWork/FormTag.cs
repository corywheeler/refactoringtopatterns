using System.Collections.Generic;

namespace ExtractComposite.MyWork
{
    public class FormTag: CompositeTag
    {
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
            GetAllNodesList().ForEach(node => stringRepresentation += node.ToPlainTextString());
            return stringRepresentation;
        }

        private List<Node> GetAllNodesList()
        {
            return _nodeList;
        }
    }
}