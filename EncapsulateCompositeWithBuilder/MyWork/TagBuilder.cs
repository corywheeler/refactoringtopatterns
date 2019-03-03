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

        public string ToXml()
        {
            return this.rootNode.ToString();
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