using EncapsulateCompositeWithBuilder.MyWork;

namespace EncapsulateCompositeWithBuilder.MyWork
{
    public class TagBuilder
    {
        private TagNode rootNode;
        private TagNode currentNode;

        public TagBuilder(string rootTagName)
        {
            this.rootNode = new TagNode(rootTagName);
            this.currentNode = this.rootNode;
        }

        public string ToXml()
        {
            return this.rootNode.ToString();
        }

        public void AddChild(string childTagName)
        {
            AddTo(this.currentNode, childTagName);
        }

        public void AddSibling(string siblingTagName)
        {
            AddTo(currentNode.Parent, siblingTagName);
        }

        private void AddTo(TagNode parentNode, string tagName)
        {
            this.currentNode = new TagNode(tagName);
            parentNode.Add(this.currentNode);
        }
    }
}