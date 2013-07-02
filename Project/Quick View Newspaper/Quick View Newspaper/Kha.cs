using System;
using System.Windows.Forms;
using System.Drawing;

namespace Quick_View_Newspaper
{
    class Kha
    {
        int flag = 1;
        double opacity = 0.6;
        Timer tmr;
        /// <summary>
        /// Thay đổi độ mờ của FORM theo 5 cấp
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
            tmr = new Timer();
            tmr.Interval = 1;
            tmr.Start();
            fm.KeyDown += fm_KeyDown;
            tmr.Tick += new EventHandler((sender, e) => timer1_Tick(sender, e, fm));
            fm.KeyUp += fm_KeyUp;
        }


        /// <summary>
        /// Bắt sự kiện ấn phím Ctrl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void fm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt)
            {
                flag = 0;
            }
        }

        /// <summary>
        /// Bắt sự kiện thả phím Ctrl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void fm_KeyUp(object sender, KeyEventArgs e)
        {
            if (!e.Alt)
            {
                flag = 1;
            }
        }


        ///// <summary>
        ///// Lấy khoảng cách giữa chuột và form /200 = độ mờ của form
        ///// </summary>
        ///// <param name="MouseX"></param>
        ///// <param name="pnlMainY"></param>
        ///// <returns></returns>
        //public double Distance(int MouseX, int pnlMainY)
        //{
        //    int intDistance = Math.Abs(MouseX - pnlMainY);
        //    Double dbDistance = Convert.ToDouble(intDistance);
        //    double temp = dbDistance / 200;
        //    //Nếu độ mờ < 0.2 thì lấy 0.2
        //    if (temp < 0.2)
        //    {
        //        return 0.2;
        //    }
        //    //Nếu độ mờ lớn hơn giá trị opacity thì lấy opacity
        //    else if (temp > opacity)
        //    {
        //        return opacity;
        //    }
        //    //Các trường hợp còn lại thì lấy bằng đúng độ mờ tính ra
        //    else
        //    {
        //        return temp;
        //    }

        //}
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
            //Nếu chuột phía trên form + nữa chiều rộng của form thì độ mờ bằng opacity
            if (intMouseY < (intFormY - fm.Height/2))
            {
                fm.Opacity = opacity;
                //fm.Activate();
            }
            //Nếu chuột phía trên form + nữa chiều rộng của form  thì độ mờ bằng công thức tính
            //if (intMouseY >= (intFormY - fm.Height/2) && intMouseY < fm.Location.Y)
            //{
            //    fm.Opacity = Distance(intMouseY, intFormY);
            //}
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
            //Nếu chuột dưới form thì độ mờ bằng opacity
            else if (intMouseY > (fm.Location.Y + fm.Height))
            {
                fm.Opacity = opacity;

            }
        }
        /// <summary>
        /// Thay đổi kích thước chữ
        /// </summary>
        /// <param name="pnlMain"></param>
        /// <param name="Size"></param>
        /// <param name="fm"></param>
        /// <returns></returns>
        public int ReSize(Panel pnlMain, int Size, Form fm)
        {
            //Kiểm tra giá trị của NumeircUpDown 
            switch (Size)
            {
                case 5:
                    pnlMain.Size = new Size((fm.Width - 54), 32);
                    Size = 7;
                    break;
                case 10:
                    pnlMain.Size = new Size((fm.Width - 54), 35);
                    break;
                case 15:
                    pnlMain.Size = new Size((fm.Width - 54), 40);
                    break;
                case 20:
                    pnlMain.Size = new Size((fm.Width - 54), 45);
                    break;
                case 25:
                    pnlMain.Size = new Size((fm.Width - 54), 50);
                    break;
                case 30:
                    pnlMain.Size = new Size((fm.Width - 54), 55);
                    break;
            }
            return Size;
        }
    }
}
