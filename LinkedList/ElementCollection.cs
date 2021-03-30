using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
	class ElementCollection
	{
        private Element _first;
        private Element _last;
        public int Count { get; private set; }

        public ElementCollection()
        {
            Count = 0;
        }

        private void AddFirst(int value)
        {
            _first = new Element
            {
                Value = value,
                Next = null,
                Previous = null
            };
            _last = _first;
            Count++;

        }

        public void AddEnd(int value)
		{
            if(Count == 0)
			{
                AddFirst(value);
                return;
			}
            var newEnd = new Element
            {
                Value = value,
                Next = null,
                Previous = _last
            };
            _last.Next = newEnd;
            _last = newEnd;
            Count++;

		}
        public int Get(int index)
        {
            return GetElement(index).Value;
        }

        public Element GetElement(int index)
        {
            if (index > Count)
                throw new IndexOutOfRangeException();

            var current = _first;
            for (var i = 1; i < index; i++)
			{
                current = current.Next;
			}

            return current;
        }

        public Element Remove(int index)
		{
            var removeElement = GetElement(index);
            if(removeElement.Previous != null)
			{
                removeElement.Previous.Next = removeElement.Next;
			}
			else
			{
                _first = removeElement.Next;
			}

			if (removeElement.Next != null)
			{
                removeElement.Next.Previous = removeElement.Previous;
			}
			else
			{
                _last = removeElement.Previous;
			}
            removeElement.Previous = null;
            removeElement.Next = null;
            Count--;
            return removeElement;
        }
    }
}
