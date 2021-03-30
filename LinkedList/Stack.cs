using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
	class Stack
	{
		private ElementCollection collection = new ElementCollection();
		public int Count { get; private set; }
		public Stack()
		{
			Count = 0;
		}

		public void Push(int value)
		{
			collection.AddEnd(value);
			Count++;
		}

		public int Pop()
		{
			return collection.Remove(Count--).Value;
		}

		public int Peek()
		{
			return collection.Get(Count);
		}
	}
}
