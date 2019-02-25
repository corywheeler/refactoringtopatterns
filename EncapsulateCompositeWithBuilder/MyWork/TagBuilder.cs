using EncapsulateCompositeWithBuilder.MyWork;

namespace EncapsulateCompositeWithBuilder.MyWork
{
    public class TagBuilder
    {
        private TagNode rootTagName;

        public TagBuilder(string rootTagName)
        {
            this.rootTagName = new TagNode(rootTagName);
        }

        public string ToXml()
        {
            return this.rootTagName.ToString();
        }
    }
}