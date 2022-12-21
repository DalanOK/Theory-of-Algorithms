namespace HashTabel
{
    public class Key
    {
        private string stock;
        private int dayOfYear;
        public Key(string stock, int dayOfYear)
        {
            this.stock = stock;
            this.dayOfYear = dayOfYear;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            HashTab<Key,double> hash = new HashTab<Key,double>(10);
            Key key1 = new Key("a", 1);
            Key key2 = new Key("b", 2);
            Key key3 = new Key("aa", 1);
            hash.Add(key1, 12.2);
            hash.Add(key2, 12.5);
            hash.Add(key3, 12.3);
            //Console.WriteLine(hash.Size);
            hash.Remove(key2);
            hash.Add(key2, 12.5);
            //Console.WriteLine(hash.Size);
            //Console.WriteLine(hash.containsKey(key3));
            //Console.WriteLine(hash.containsKey(new Key ("a",6 )));
            //Console.WriteLine(hash.Get(key2));
        }
    }
}