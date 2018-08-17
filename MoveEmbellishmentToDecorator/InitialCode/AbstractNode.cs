using System;

namespace MoveEmbellishmentToDecorator.InitialCode
{
    public abstract class AbstractNode : Node
    {
        private int nodeBegin;
        private int nodeEnd;

        public AbstractNode(int beginPosition, int endPosition)
        {
        }

        public abstract string toPlainTextString();

        public abstract string toHtml();

        public string toString()
        {
            throw new NotImplementedException();
        }

        public void collectInfo(NodeList nodes, string filter)
        {
        }

        public void collectInfo(NodeList nodes, Type nodeType)
        {
        }

        public int elementBegin()
        {
            throw new NotImplementedException();
        }

        public int elementEnd()
        {
            throw new NotImplementedException();
        }

        public void accept(NodeVisitor visitor)
        {
        }

        public void setParent(CompositeTag tag)
        {
        }

        public CompositeTag getParent()
        {
            throw new NotImplementedException();
        }
    }
}