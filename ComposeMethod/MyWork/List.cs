using System;

namespace ComposeMethod.MyWork
{
    public class List
    {
        private static int GROWTH_INCREMENT = 10;
        private bool _readOnly;
        private int _size;
        private Object[] _elements = new Object[] { };

        public void Add(Object element)
        {

            if (_readOnly)
            {
                return;
            }

            if (AtCapacity())
            {
                Grow();
            }

            AddElement(element);

        }

        private bool AtCapacity()
        {
            return _size + 1 > _elements.Length;
        }

        private void Grow()
        {
            Object[] newElements = new Object[_elements.Length + GROWTH_INCREMENT];

            for (int i = 0; i < _size; i++)
                newElements[i] = _elements[i];

            _elements = newElements;
        }

        private void AddElement(object element)
        {
            _elements[_size++] = element;
        }

        public int Count
        {
            get
            {
                return _size;
            }
        }
    }
}
