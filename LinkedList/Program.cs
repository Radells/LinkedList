using System;

namespace LinkedList
{
	class Program
	{
		static void Main(string[] args)
		{
			var arrayNumbers = new int[]
			{
				5,
				10,
				15,
				20,
				25
			};
			var queue = new Queue(3);
			var stack = new Stack();
			var arrayString = new string[]
			{
				"получил значение:",
				"Удалил значение:"
			};
			
			Console.WriteLine("Работа с очередью:");
			for(var i = 0; i < arrayNumbers.Length; i++)
			{
				queue.Enqueue(arrayNumbers[i]);
			}
	

			for (var i = 0; i < arrayNumbers.Length; i++)
			{
				Console.WriteLine($"{arrayString[0]} {queue.Peek()}");
				Console.WriteLine($"{arrayString[1]} {queue.Dequeue()}");
			}
			
			Console.WriteLine("\n\rРабота со стеком:");
			for (var i = 0; i < arrayNumbers.Length; i++)
			{
				stack.Push(arrayNumbers[i]);
			}


			for (var i = 0; i < arrayNumbers.Length; i++)
			{
				Console.WriteLine($"{arrayString[0]} {stack.Peek()}");
				Console.WriteLine($"{arrayString[1]} {stack.Pop()}");
			}
		}
	}
}
