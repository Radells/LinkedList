using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class ElementCollection
    {
        private int _count;
        private Element _first;
        private Element _last;

        public ElementCollection()
        {
            _count = 0;
        }

        public void CreateElement(int index)
        {
            if (_first == null)
            {
                _first = _last = new Element
                {
                    Value = index
                };
                _count++;
            }
            else
            {
                _last = new Element
                {
                    Value = index
                };
                _count++;
            }
        }
        public int Get(int index)
        {
            return GetElement(index).Value;
        }

        public Element GetElement(int index)
        {
            if (index > _count)
                throw new IndexOutOfRangeException();

            return _last;
        }

    }
}
