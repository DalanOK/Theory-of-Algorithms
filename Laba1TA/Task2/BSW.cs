using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public static class BSW
    {
        private static int n;
        private static int m;
        public static bool[,] minDistance(char[,] grid)
        {
            n = grid.GetLength(0);
            m = grid.GetLength(1);
            QItem source = new QItem(0,0,0);
            bool[,] visited = new bool[n, m];
            bool[,] path = new bool[n, m];
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    if(grid[i,j] == '#')
                    {
                        visited[i,j] = true;
                    }
                    else
                    {
                        visited[i,j] = false;
                    }
                    if(grid[i,j] == 'S')
                    {
                        source.row = i;
                        source.col = j;
                    }
                }
            }
            Queue<QItem> q = new Queue<QItem>();
            q.Enqueue(source);
            visited[source.row,source.col] = true;
            while(q.Count > 0)
            {
                QItem p = q.Dequeue();


                if (grid[p.row, p.col] == 'F')
                {
                    QItem item = p.parrent;
                    while (item.parrent != null)
                    {
                        path[item.row, item.col] = true;
                        item = item.parrent;
                    }
                    return path;
                }
                //up
                if(p.row - 1 >= 0 && visited[p.row - 1, p.col] == false)
                {
                    q.Enqueue(new QItem(p.row - 1, p.col, p.dist + 1, p));
                    visited[p.row - 1, p.col] = true;
                }
                //down
                if(p.row + 1 < n && visited[p.row + 1, p.col] == false)
                {
                    q.Enqueue(new QItem(p.row + 1, p.col, p.dist + 1, p));
                    visited[p.row + 1, p.col] = true;
                }
                //left
                if (p.col - 1 >= 0 && visited[p.row, p.col - 1] == false)
                {
                    q.Enqueue(new QItem(p.row,p.col - 1, p.dist + 1, p));
                    visited[p.row,p.col - 1] = true;
                }
                //right
                if (p.col + 1 < m && visited[p.row, p.col + 1] == false)
                {
                    q.Enqueue(new QItem(p.row, p.col + 1, p.dist + 1, p));
                    visited[p.row, p.col + 1] = true;
                }
            }
            return path;
        }
    }
}
