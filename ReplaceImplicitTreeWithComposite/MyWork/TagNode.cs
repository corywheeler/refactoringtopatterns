using System.Collections.Generic;
using System.Text;

namespace ReplaceImplicitTreeWithComposite.MyWork
{
    public class TagNode
    {
        private StringBuilder attributes;
        private IList<TagNode> children = new List<TagNode>();
        private string name;
        private string value = string.Empty;

        public TagNode(string name)
        {
            this.name = name;
            this.attributes = new StringBuilder();
        }

        public void Add(TagNode tagNode)
        {
            this.children.Add(tagNode);
        }

        public void AddAttribute(string attribute, string value)
        {
            this.attributes.Append(" ");
            this.attributes.Append(attribute);
            this.attributes.Append("='");
            this.attributes.Append(value);
            this.attributes.Append("'");
        }

        public void AddValue(string value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            var result =
                "<" + this.name + this.attributes + ">";

            foreach (TagNode tagNode in this.children)
            {
                result += tagNode.ToString();
            }

            result += this.value +
                "</" + this.name + ">";
            return result;
        }
    }
}