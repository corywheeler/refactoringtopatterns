using System;
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
            TagNode parentNode = this.currentNode;
            this.currentNode = new TagNode(childTagName);
            parentNode.Add(this.currentNode);
        }

        public void AddSibling(string v)
        {
            throw new NotImplementedException();
        }
    }
}