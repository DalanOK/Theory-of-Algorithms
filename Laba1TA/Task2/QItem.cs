using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class QItem
    {
        public int row;
        public int col;
        public int dist;
        public QItem parrent;
        public QItem(int x, int y, int w)
        {
            this.row = x;
            this.col = y;
            this.dist = w;
        }
        public QItem(int row, int col, int dist,QItem parentt) : this(row, col, dist)
        {
            parrent = parentt;
        }
    }
}
