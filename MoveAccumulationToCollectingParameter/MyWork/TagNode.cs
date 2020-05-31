using System;
using System.Collections.Generic;

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
            string result = String.Empty;

            result += "<" + _tagName + " " + _attributes + ">";

            if (!_value.Equals(""))
            {
                result += _value;
            }
            
            foreach (TagNode child in _children)
            {
                result += child.ToString();
            }

            result += "</" + _tagName + ">";
            return result;
        }
    }
}