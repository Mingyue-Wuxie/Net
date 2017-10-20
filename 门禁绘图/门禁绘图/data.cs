using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace 门禁绘图
{
    class data
    {
        datatype[] datas = new datatype[46];

        public data()
        {
            for (int i = 0; i < datas.Length; i++)
            {
                datas[i] = new datatype();
            }
            datas[0].Data(710, 66, new Point(710, 300), 0);
            datas[1].Data(710, 300, new Point(710, 66), 0);

            datas[2].Data(710, 87, new Point(710, 281), 1);
            datas[3].Data(710, 281, new Point(710, 87), 1);

            datas[4].Data(710, 24, new Point(710, 245), 2);
            datas[5].Data(710, 245, new Point(710, 24), 2);

            datas[6].Data(710, 47, new Point(710, 262), 3);
            datas[7].Data(710, 262, new Point(710, 47), 3);

            datas[8].Data(710, 245, new Point(710, 392), 4);
            datas[9].Data(710, 392, new Point(710, 245), 4);

            datas[10].Data(710, 262, new Point(710, 408), 5);
            datas[11].Data(710, 408, new Point(710, 262), 5);

            datas[12].Data(710, 392, new Point(710, 562), 6);
            datas[13].Data(710, 562, new Point(710, 392), 6);

            datas[14].Data(710, 408, new Point(710, 544), 7);
            datas[15].Data(710, 544, new Point(710, 408), 7);

            datas[16].Data(710, 172, new Point(509, 270), 8);
            datas[17].Data(509, 270, new Point(710, 172), 8);

            datas[18].Data(710, 193, new Point(509, 284), 9);
            datas[19].Data(509, 284, new Point(710, 193), 9);

            datas[20].Data(710, 210, new Point(710, 583), 10);
            datas[21].Data(710, 583, new Point(710, 210), 10);

            datas[22].Data(710, 374, new Point(710, 524), 11);
            datas[23].Data(710, 524, new Point(710, 374), 11);

            datas[24].Data(710, 355, new Point(710, 484), 12);
            datas[25].Data(710, 484, new Point(710, 355), 12);

            datas[26].Data(710, 193, new Point(522, 408), 13);
            datas[27].Data(522, 408, new Point(710, 193), 13);

            datas[28].Data(710, 172, new Point(522, 424), 14);
            datas[29].Data(522, 424, new Point(710, 172), 14);

            datas[30].Data(509, 270, new Point(522, 424), 15);
            datas[31].Data(522, 424, new Point(509, 270), 15);

            datas[32].Data(509, 284, new Point(522, 408), 16);
            datas[33].Data(522, 408, new Point(509, 284), 16);

            datas[34].Data(710, 24, new Point(710, 392), 17);
            datas[35].Data(710, 392, new Point(710, 24), 17);

            datas[36].Data(710, 47, new Point(710, 408), 18);
            datas[37].Data(710, 408, new Point(710, 47), 18);

            datas[38].Data(710, 245, new Point(710, 562), 19);
            datas[39].Data(710, 562, new Point(710, 245), 19);

            datas[40].Data(710, 262, new Point(710, 544), 20);
            datas[41].Data(710, 544, new Point(710, 262), 20);

            datas[42].Data(710, 24, new Point(710, 562), 21);
            datas[43].Data(710, 562, new Point(710, 24), 21);

            datas[44].Data(710, 47, new Point(710, 544), 22);
            datas[45].Data(710, 544, new Point(710, 47), 22);
        }

        public int sdata(double X1, double Y1, Point End)
        {
            int indexOf = -1;
            int BorderThickness = 5;
            for (int i = 0; i < datas.Length; i++)
            {
                if ((X1 - BorderThickness <= datas[i].X1 && X1 + BorderThickness >= datas[i].X1) && (Y1 - BorderThickness <= datas[i].Y1 && Y1 + BorderThickness >= datas[i].Y1))
                {
                    if ((End.Y - BorderThickness <= datas[i].End.Y && End.Y + BorderThickness >= datas[i].End.Y) && (End.Y - BorderThickness <= datas[i].End.Y && End.Y + BorderThickness >= datas[i].End.Y))
                    {
                        indexOf = datas[i].indexOf;
                    }
                }
            }
            return indexOf;
        }
    }
}
