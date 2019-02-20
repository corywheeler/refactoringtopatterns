using System.Text;

namespace ReplaceImplicitTreeWithComposite.MyWork
{
    public class TagNode
    {
        private string name;
        private StringBuilder attributes;
        private string value = string.Empty;

        public TagNode(string name)
        {
            this.name = name;
            this.attributes = new StringBuilder();
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
                "<" + this.name + this.attributes + ">" +
                this.value +
                "</" + this.name + ">";
            return result;
        }
    }
}