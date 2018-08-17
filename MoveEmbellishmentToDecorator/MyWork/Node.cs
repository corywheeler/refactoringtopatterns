using System;

namespace MoveEmbellishmentToDecorator.MyWork
{
    public interface Node
    {
        string toPlainTextString();

        string toHtml();

        string toString();

        void collectInfo(NodeList nodes, string filter);

        void collectInfo(NodeList nodes, Type nodeType);

        int elementBegin();

        int elementEnd();

        void setParent(CompositeTag tag);

        CompositeTag getParent();
    }
}