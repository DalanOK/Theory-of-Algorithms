namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] grid = { { '.', '.', '#', '.' },
                             { '.', '.', '.', '.' },
                             { '#', '.', '#', 'S' },
                             { '.', '.', '.', '#' },
                             { '.', '.', '.', '.' },
                             { '.', '.', 'F', '.' },
                             { '.', '.', '#', '.' }
            };
            //  Console.WriteLine(BSW.minDistance(grid));
             Print(grid);
        }
        public static void Print(char[,] arr)
        {
            bool[,] path = BSW.minDistance(arr);
            for(int i = 0; i < path.GetLength(0); i++)
            {
                Console.WriteLine();
                for(int j = 0; j < path.GetLength(1); j++)
                {
                    if(path[i, j] == true)
                    {
                        arr[i, j] = 'X';
                    }
                    Console.Write(arr[i,j]);
                }
            }
        }
    }
}