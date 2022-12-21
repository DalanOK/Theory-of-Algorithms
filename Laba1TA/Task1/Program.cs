namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> q = new Queue<string>();
            q.Enqueue("Item1");
            q.Enqueue("Item2");
            q.Dequeue();
            q.Dequeue();
            q.Enqueue("Item3");
            q.Dequeue();
            q.Enqueue("Item4");
            q.Enqueue("Item5");
            Console.WriteLine(q.Count);

        }
    }
}