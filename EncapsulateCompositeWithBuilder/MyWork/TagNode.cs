using System.Collections.Generic;
using System.Text;

namespace EncapsulateCompositeWithBuilder.MyWork
{
    public class TagNode
    {
        private StringBuilder attributes;
        private IList<TagNode> children = new List<TagNode>();
        private string value = string.Empty;

        public string Name { get; }
        public TagNode Parent { get; private set; }

        public TagNode(string name)
        {
            this.attributes = new StringBuilder();
            this.Name = name;
        }

        public void Add(TagNode childNode)
        {
            childNode.Parent = this;
            this.children.Add(childNode);
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
                "<" + this.Name + this.attributes + ">";

            if (this.ShouldSelfClose())
            {
                return result.Replace(">", "/>");
            }

            foreach (TagNode tagNode in this.children)
            {
                result += tagNode.ToString();
            }

            result += this.value +
                "</" + this.Name + ">";
            return result;
        }

        private bool ShouldSelfClose()
        {
            return !this.HasValue() && !this.HasChildren();
        }

        private bool HasChildren()
        {
            return this.children.Count > 0;
        }

        private bool HasValue()
        {
            return !this.value.Equals(string.Empty);
        }
    }
}