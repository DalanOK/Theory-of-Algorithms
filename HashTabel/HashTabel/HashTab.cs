using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTabel
{
    public class HashTab<T, TU>
    {
        private List<Tuple<T,TU>>[] items;
        private int size = 0;

        public HashTab(int s)
        {
            items = new List<Tuple<T,TU>>[s];
        }
        public int Size { get { return size; } }
        public void Add(T key, TU value)
        {
            int pos = GetPosition(key);
            if(items[pos] == null)
            {
                items[pos] = new List<Tuple<T, TU>>();
            }
            if (items[pos].Any(x => x.Item1.Equals(key)))
            {
                throw new Exception("Duplicate key");
            }
            items[pos].Add(new Tuple<T, TU>(key, value));
            size++;
        }
        public TU Get(T key)
        {
            int pos = GetPosition(key);
            foreach (var item in items[pos])
            {
                if (item.Item1.Equals(key))
                {
                    return item.Item2;
                }
            }
            throw new Exception("Key does not exist");
        }
        public bool containsKey(T key)
        {
            int pos = GetPosition(key);
            if (items[pos] != null)
            {
                foreach (var item in items[pos])
                {
                    if (item.Item1.Equals(key))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public void Remove(T key)
        {
            var pos = GetPosition(key);
            if (items[pos] != null)
            {
                foreach(var item in items[pos].ToList())
                {
                    if (item.Item1.Equals(key))
                    {
                        items[pos].Remove(item);
                        size--;
                    }
                }
            }
            else
            {
                throw new Exception("Value not in HashTable");
            }
        }
        private int GetHash(T key)
        {
            int num = 20;
            return key.ToString().Length / num;
        }
        private int GetPosition(T key)
        {
            return Math.Abs(key.GetHashCode() % items.Length);
        }
    }
}
