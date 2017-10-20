using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace 门禁绘图
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            init();
        }

        Polyline[] polyline = new Polyline[23];
        data data = new data();

        void init()
        {
            polyline[0] = bell0;
            polyline[1] = bell1;
            polyline[2] = ling0;
            polyline[3] = ling1;
            polyline[4] = crad0;
            polyline[5] = crad1;
            polyline[6] = suo0;
            polyline[7] = suo1;
            polyline[8] = dgnd;
            polyline[9] = opensw;
            polyline[10] = push;
            polyline[11] = com0;
            polyline[12] = com1;
            polyline[13] = openswl;
            polyline[14] = dgndn;
            polyline[15] = nn;
            polyline[16] = ll;
            polyline[17] = lingsuo0;
            polyline[18] = lingsuo1;
            polyline[19] = cradv0;
            polyline[20] = cradv1;
            polyline[21] = lingv0;
            polyline[22] = lingv1;
            for (int i = 0; i < polyline.Length; i++)
            {
                polyline[i].Visibility = Visibility.Hidden;
            }
        }

        private void B0_MouseMove(object sender, MouseEventArgs e)
        {
            B0.Opacity = 1;
        }

        private void B1_MouseMove(object sender, MouseEventArgs e)
        {
            B1.Opacity = 1;
        }

        private void B2_MouseMove(object sender, MouseEventArgs e)
        {
            B2.Opacity = 1;
        }

        private void B3_MouseMove(object sender, MouseEventArgs e)
        {
            B3.Opacity = 1;
        }

        private void B4_MouseMove(object sender, MouseEventArgs e)
        {
            B4.Opacity = 1;
        }

        private void B5_MouseMove(object sender, MouseEventArgs e)
        {
            B5.Opacity = 1;
        }

        private void B6_MouseMove(object sender, MouseEventArgs e)
        {
            B6.Opacity = 1;
        }

        private void B7_MouseMove(object sender, MouseEventArgs e)
        {
            B7.Opacity = 1;
        }

        private void B8_MouseMove(object sender, MouseEventArgs e)
        {
            B8.Opacity = 1;
        }

        private void B9_MouseMove(object sender, MouseEventArgs e)
        {
            B9.Opacity = 1;
        }

        private void B10_MouseMove(object sender, MouseEventArgs e)
        {
            B10.Opacity = 1;
        }

        private void B11_MouseMove(object sender, MouseEventArgs e)
        {
            B11.Opacity = 1;
        }

        private void B12_MouseMove(object sender, MouseEventArgs e)
        {
            B12.Opacity = 1;
        }

        private void B13_MouseMove(object sender, MouseEventArgs e)
        {
            B13.Opacity = 1;
        }

        private void B14_MouseMove(object sender, MouseEventArgs e)
        {
            B14.Opacity = 1;
        }

        private void B15_MouseMove(object sender, MouseEventArgs e)
        {
            B15.Opacity = 1;
        }

        private void B16_MouseMove(object sender, MouseEventArgs e)
        {
            B16.Opacity = 1;
        }

        private void B17_MouseMove(object sender, MouseEventArgs e)
        {
            B17.Opacity = 1;
        }

        private void B18_MouseMove(object sender, MouseEventArgs e)
        {
            B18.Opacity = 1;
        }

        private void B19_MouseMove(object sender, MouseEventArgs e)
        {
            B19.Opacity = 1;
        }

        private void B20_MouseMove(object sender, MouseEventArgs e)
        {
            B20.Opacity = 1;
        }

        private void B21_MouseMove(object sender, MouseEventArgs e)
        {
            B21.Opacity = 1;
        }

        private void B22_MouseMove(object sender, MouseEventArgs e)
        {
            B22.Opacity = 1;
        }

        private void B0_MouseLeave(object sender, MouseEventArgs e)
        {
            B0.Opacity = 0;
        }

        private void B1_MouseLeave(object sender, MouseEventArgs e)
        {
            B1.Opacity = 0;
        }

        private void B2_MouseLeave(object sender, MouseEventArgs e)
        {
            B2.Opacity = 0;
        }

        private void B3_MouseLeave(object sender, MouseEventArgs e)
        {
            B3.Opacity = 0;
        }

        private void B4_MouseLeave(object sender, MouseEventArgs e)
        {
            B4.Opacity = 0;
        }

        private void B5_MouseLeave(object sender, MouseEventArgs e)
        {
            B5.Opacity = 0;
        }

        private void B6_MouseLeave(object sender, MouseEventArgs e)
        {
            B6.Opacity = 0;
        }

        private void B7_MouseLeave(object sender, MouseEventArgs e)
        {
            B7.Opacity = 0;
        }

        private void B8_MouseLeave(object sender, MouseEventArgs e)
        {
            B8.Opacity = 0;
        }

        private void B9_MouseLeave(object sender, MouseEventArgs e)
        {
            B9.Opacity = 0;
        }

        private void B10_MouseLeave(object sender, MouseEventArgs e)
        {
            B10.Opacity = 0;
        }

        private void B11_MouseLeave(object sender, MouseEventArgs e)
        {
            B11.Opacity = 0;
        }

        private void B12_MouseLeave(object sender, MouseEventArgs e)
        {
            B12.Opacity = 0;
        }

        private void B13_MouseLeave(object sender, MouseEventArgs e)
        {
            B13.Opacity = 0;
        }

        private void B14_MouseLeave(object sender, MouseEventArgs e)
        {
            B14.Opacity = 0;
        }

        private void B15_MouseLeave(object sender, MouseEventArgs e)
        {
            B15.Opacity = 0;
        }

        private void B16_MouseLeave(object sender, MouseEventArgs e)
        {
            B16.Opacity = 0;
        }

        private void B17_MouseLeave(object sender, MouseEventArgs e)
        {
            B17.Opacity = 0;
        }

        private void B18_MouseLeave(object sender, MouseEventArgs e)
        {
            B18.Opacity = 0;
        }

        private void B19_MouseLeave(object sender, MouseEventArgs e)
        {
            B19.Opacity = 0;
        }

        private void B20_MouseLeave(object sender, MouseEventArgs e)
        {
            B20.Opacity = 0;
        }

        private void B21_MouseLeave(object sender, MouseEventArgs e)
        {
            B21.Opacity = 0;
        }

        private void B22_MouseLeave(object sender, MouseEventArgs e)
        {
            B22.Opacity = 0;
        }

        private void B23_MouseMove(object sender, MouseEventArgs e)
        {
            B23.Opacity = 1;
        }

        private void B23_MouseLeave(object sender, MouseEventArgs e)
        {
            B23.Opacity = 0;
        }

        private void Canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            line.X1 = e.GetPosition(Canvas).X;
            line.Y1 = e.GetPosition(Canvas).Y;
        }

        private void Canvas_MouseUp(object sender, MouseButtonEventArgs e)
        {
            int indexOf = data.sdata(line.X1, line.Y1, e.GetPosition(Canvas));
            if (indexOf != -1)
            {
                polyline[indexOf].Visibility = Visibility.Visible;
            }
            line.Visibility = Visibility.Collapsed;
            if (end())
            {
                if (MessageBox.Show("是否重置,重置选择是", "恭喜完成", MessageBoxButton.YesNo, MessageBoxImage.Asterisk) == MessageBoxResult.Yes)
                {
                    init();
                }
            }
        }

        private bool end()
        {
            bool[] vis = new bool[10];
            vis[0] = bell0.Visibility == Visibility.Visible ? true : false;
            vis[1] = bell1.Visibility == Visibility.Visible ? true : false;
            vis[2] = push.Visibility == Visibility.Visible ? true : false;
            vis[3] = com0.Visibility == Visibility.Visible ? true : false;
            vis[4] = com1.Visibility == Visibility.Visible ? true : false;
            vis[5] = zheng() >= 3 ? true : false;
            vis[6] = fu() >= 3 ? true : false;
            vis[7] = dgnds() >= 2 ? true : false;
            vis[8] = open() >= 2 ? true : false;
            vis[9] = true;
            for (int i = 0; i < vis.Length; i++)
            {
                if (!vis[i])
                {
                    vis[9] = false;
                }
            }
            return vis[9];
        }

        private int fu()
        {
            int Namber = 0;
            Namber = ling0.Visibility == Visibility.Visible ? Namber + 1 : Namber;
            Namber = lingsuo0.Visibility == Visibility.Visible ? Namber + 1 : Namber;
            Namber = crad0.Visibility == Visibility.Visible ? Namber + 1 : Namber;
            Namber = suo0.Visibility == Visibility.Visible ? Namber + 1 : Namber;
            Namber = lingv0.Visibility == Visibility.Visible ? Namber + 1 : Namber;
            Namber = cradv0.Visibility == Visibility.Visible ? Namber + 1 : Namber;
            return Namber;
        }

        private int zheng()
        {
            int Namber = 0;
            Namber = ling1.Visibility == Visibility.Visible ? Namber + 1 : Namber;
            Namber = lingsuo1.Visibility == Visibility.Visible ? Namber + 1 : Namber;
            Namber = lingv1.Visibility == Visibility.Visible ? Namber + 1 : Namber;
            Namber = crad1.Visibility == Visibility.Visible ? Namber + 1 : Namber;
            Namber = cradv1.Visibility == Visibility.Visible ? Namber + 1 : Namber;
            Namber = suo1.Visibility == Visibility.Visible ? Namber + 1 : Namber;
            return Namber;
        }

        private int open()
        {
            int Namber = 0;
            Namber = opensw.Visibility == Visibility.Visible ? Namber + 1 : Namber;
            Namber = openswl.Visibility == Visibility.Visible ? Namber + 1 : Namber;
            Namber = ll.Visibility == Visibility.Visible ? Namber + 1 : Namber;
            return Namber;
        }

        private int dgnds()
        {
            int Namber = 0;
            Namber = dgnd.Visibility == Visibility.Visible ? Namber + 1 : Namber;
            Namber = dgndn.Visibility == Visibility.Visible ? Namber + 1 : Namber;
            Namber = nn.Visibility == Visibility.Visible ? Namber + 1 : Namber;
            return Namber;
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                line.Visibility = Visibility.Visible;
                line.X2 = e.GetPosition(Canvas).X;
                line.Y2 = e.GetPosition(Canvas).Y;
            }
        }
    }
}
