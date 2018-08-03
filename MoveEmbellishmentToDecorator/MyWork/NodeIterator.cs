using System.Collections.Generic;

namespace MoveEmbellishmentToDecorator.MyWork
{
    public class NodeIterator
    {
        private List<Node>.Enumerator _enumerator;

        public NodeIterator(List<Node> stringNodes)
        {
            _enumerator = stringNodes.GetEnumerator();
        }

        public bool hasMoreNodes()
        {
            return _enumerator.MoveNext();
        }

        public Node nextNode()
        {
            return _enumerator.Current;
        }
    }
}