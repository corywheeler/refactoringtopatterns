using EncapsulateCompositeWithBuilder.MyWork;
using System;

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

        public void AddAttribute(string name, string value)
        {
            this.currentNode.AddAttribute(name, value);
        }

        public void AddChild(string childTagName)
        {
            this.AddTo(this.currentNode, childTagName);
        }

        public void AddSibling(string siblingTagName)
        {
            this.AddTo(currentNode.Parent, siblingTagName);
        }

        public void AddToParent(string parentTagName, string childTagName)
        {
            TagNode parentNode = this.FindParentBy(parentTagName);
            if (parentNode == null)
                throw new SystemException("missing parent tag: " + parentTagName);
            this.AddTo(parentNode, childTagName);
        }

        public void AddValue(string value)
        {
            this.currentNode.AddValue(value);
        }

        public string ToXml()
        {
            return this.rootNode.ToString();
        }

        private void AddTo(TagNode parentNode, string tagName)
        {
            this.currentNode = new TagNode(tagName);
            parentNode.Add(this.currentNode);
        }

        private TagNode FindParentBy(string parentName)
        {
            TagNode parentNode = this.currentNode;
            while (parentNode != null)
            {
                if (parentName.Equals(parentNode.Name))
                    return parentNode;
                parentNode = parentNode.Parent;
            }

            return null;
        }
    }
}