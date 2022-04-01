using System;
using System.Collections;
using System.Collections.Generic;

namespace General_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            Queue queues = new Queue();
            queues.Enqueue("Jale");
            queues.Enqueue("Konul");
            queues.Enqueue("Ilknur");

            foreach (var item in queues.Reserve(queue))
            {
                Console.WriteLine(item);
            }


        }
    }
}
