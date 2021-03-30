using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
	class Queue
	{
		private ElementCollection collection = new ElementCollection();

		public int Count { get; private set; }
		private int _numberQueue;

		public Queue()
		{
		   Count = 3;
		   _numberQueue = 0;
		}
		public Queue(int count)
		{
			Count = count;
		}

		public void Enqueue(int value)
		{
			if (_numberQueue >= Count)
			{
				throw new IndexOutOfRangeException();
			}
			else
			{
				_numberQueue++;
				collection.AddEnd(value);
			}
		}

		public int Dequeue()
		{
			_numberQueue--;
			return collection.Remove(0).Value;
		}

		public int Peek()
		{
			return collection.Get(0);
		}
		
	}
}
