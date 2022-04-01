using System;
using System.Collections;
using System.Collections.Generic;

namespace General_Practice
{
    internal class Queue
    {
        Queue queue;
        Stack reverse;
        Queue<string> reversque;
        public Queue()
        {
            queue = new Queue();
            reverse = new Stack();
            reversque = new Queue<string>();
        }

        internal void Enqueue(string v)
        {
            throw new NotImplementedException();
        }

        public Queue<string> Reserve(Queue<String> word)
        {
            foreach (var item in word)
            {
                reverse.Push(item);
            }

            foreach (var item in reverse)
            {
                reversque.Enqueue((string)item);
            }
            return reversque;
        }
    }
}