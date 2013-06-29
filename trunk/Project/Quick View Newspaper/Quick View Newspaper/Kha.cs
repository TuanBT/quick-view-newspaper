using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Quick_View_Newspaper
{
    class Kha
    {
        int flag = 0;
        double opacity = 0.6;
        Timer Clock;
        /// <summary>
        /// Thay đổi độ mờ của FORM theo 3 cấp
        /// </summary>
        /// <param name="fm"></param>
        /// <param name="intOpacity"></param>
        public void ReOpacity(Form fm, int intOpacity)
        {
            switch (intOpacity)
            {
                case -2: fm.Opacity = 0.2;
                    opacity = 0.2;
                    break;
                case -1: fm.Opacity = 0.4;
                    opacity = 0.4;
                    break;
                case 0: fm.Opacity = 0.6;
                    opacity = 0.6;
                    break;
                case 1: fm.Opacity = 0.8;
                    opacity = 0.8;
                    break;
                case 2: fm.Opacity = 1;
                    opacity = 1;
                    break;
            }
        }
        /// <summary>
        /// Khai báo và sử dụng timer
        /// </summary>
        /// <param name="fm"></param>
        public void OpacityMouse(Form fm)
        {
            Clock = new Timer();
            Clock.Interval = 1;
            Clock.Start();
            fm.KeyDown += fm_KeyDown;
            Clock.Tick += new EventHandler((sender, e) => timer1_Tick(sender, e, fm));
            fm.KeyUp += fm_KeyUp;
        }

        //Bắt sự kiện thả phím
        void fm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                flag = 0;
            }
        }

        //Bắt sự kiện ấn phím
        void fm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                flag = 1;
            }
        }
        /// <summary>
        /// Lấy khoảng cách giữa chuột và form /200 = độ mờ của form
        /// </summary>
        /// <param name="MouseX"></param>
        /// <param name="pnlMainY"></param>
        /// <returns></returns>
        public double Distance(int MouseX, int pnlMainY)
        {
            int intDistance = Math.Abs(MouseX - pnlMainY);
            Double dbDistance = Convert.ToDouble(intDistance);
            double temp = dbDistance / 200;
            if (temp < 0.2)
            {
                return 0.2;
            }
            else if (temp > opacity)
            {
                return opacity;
            }
            else
            {
                return temp;
            }

        }
        /// <summary>
        /// Xử lý sự kiện của timmer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="fm"></param>
        private void timer1_Tick(object sender, EventArgs e, Form fm)
        {
            int intMouseY = Cursor.Position.Y;
            int intFormY = fm.Location.Y;
            if (intMouseY < (intFormY - fm.Height/2))
            {
                fm.Opacity = opacity;
            }
            //Nếu chuột phía trên form + chiều rộng của form thì cho làm mờ
            if (intMouseY >= (intFormY - fm.Height) && intMouseY < fm.Location.Y)
            {
                fm.Opacity = Distance(intMouseY, intFormY);
            }
            //Nếu chuột nằm trong form thì ẩn đi
            else if ((intMouseY <= (fm.Location.Y + fm.Height) && (intMouseY >= fm.Location.Y)))
            {
                if (flag == 0)
                {
                    fm.Opacity = 0;
                }
                else
                {
                    fm.Opacity = opacity;
                }
            }
            //Nếu chuột dưới form thì độ mờ mặc định
            else if (intMouseY > (fm.Location.Y + fm.Height))
            {
                fm.Opacity = opacity;

            }
        }

    }
}
