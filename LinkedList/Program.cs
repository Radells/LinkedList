using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new ElementCollection();
            collection.CreateElement(10);
            Console.WriteLine(collection.Get(1));

        }
    }
}
