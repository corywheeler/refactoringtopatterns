using System.Collections.Generic;

namespace ExtractComposite.MyWork
{
    public class FormTag: Tag
    {
        private readonly List<Tag> _allNodesList = new List<Tag>();

        public FormTag() : base("<form>", "</form>")
        {
            
        }
        
        public void AddChild(Tag tag)
        {
            _allNodesList.Add(tag);
        }

        public string ToPlainTextString()
        {
            var stringRepresentation = string.Empty;
            GetAllNodesList().ForEach(node => stringRepresentation += node.ToPlainTextString());
            return stringRepresentation;
        }

        private List<Tag> GetAllNodesList()
        {
            return _allNodesList;
        }
    }
}