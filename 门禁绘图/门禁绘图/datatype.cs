using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace 门禁绘图
{
    class datatype
    {
        public int X1 = 0;
        public int Y1 = 0;
        public Point End = new Point(0, 0);
        public int indexOf = -1;
        public void Data(int x1, int y1, Point end, int indexof)
        {
            X1 = x1;
            Y1 = y1;
            End = end;
            indexOf = indexof;
        }
    }
}
