using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Queue<T>
    {
        private int rear = -1;
        private int count;
        private T[] array = new T[1];
        public int Count { get { return count; } }
        public Queue()
        {
        }
        public bool IsFull()
        {
            return rear == array.Length - 1;
        }
        public bool isEmpty()
        {
            return count == 0;
        }
        public void Enqueue(T Item)
        {
            if (this.IsFull())
                Array.Resize(ref array, array.Length * 2);
            array[++rear] = Item;
            count++;
        }
        public T Dequeue()
        {
            if (this.isEmpty())
                throw new Exception("Queue is empty");
            T value = array[0];
            count--;
            return value;
        }
    }
}
