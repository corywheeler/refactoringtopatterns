using System.Collections.Generic;
using System.Text;

namespace MoveAccumulationToCollectingParameter.MyWork
{
    public class TagNode
    {
        private string _tagName;
        private string _attributes;
        private readonly string _value;
        private List<TagNode> _children;

        public TagNode(string tagName, string attributes, string value)
        {
            _attributes = attributes;
            _value = value;
            _tagName = tagName;
            _children = new List<TagNode>();
        }
        
        public void Add(TagNode childNode)
        {
            _children.Add(childNode);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            AppendContentsTo(result);
            return result.ToString();
        }

        private void AppendContentsTo(StringBuilder result)
        {
            WriteOpenTagTo(result);
            WriteValueTo(result);
            WriteChildrenTo(result);
            WriteEndTagTo(result);
        }

        private void WriteEndTagTo(StringBuilder result)
        {
            result.Append("</");
            result.Append(_tagName);
            result.Append(">");
        }

        private void WriteValueTo(StringBuilder result)
        {
            if (!_value.Equals(""))
            {
                result.Append(_value);
            }
        }

        private void WriteChildrenTo(StringBuilder result)
        {
            foreach (TagNode child in _children)
            {
                child.AppendContentsTo(result);
            }
        }

        private void WriteOpenTagTo(StringBuilder result)
        {
            result.Append("<");
            result.Append(_tagName);
            result.Append(" ");
            result.Append(_attributes);
            result.Append(">");
        }
    }
}