using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Quick_View_Newspaper
{
    class Kha
    {
        Timer Clock;
        public void ReOpacity(Form fm, int intOpacity)
        {
            switch (intOpacity)
            {
                case -2: fm.Opacity = 0.2;
                    break;
                case -1: fm.Opacity = 0.4;
                    break;
                case 0: fm.Opacity = 0.6;
                    break;
                case 1: fm.Opacity = 0.8;
                    break;
                case 2: fm.Opacity = 1;
                    break;
            }
        }
        public void OpacityMouse(Form fm)
        {
            Clock = new Timer();
            Clock.Interval = 1;
            Clock.Start();
            Clock.Tick += new EventHandler((sender, e) => timer1_Tick(sender, e, fm));
        }
        public double Distance(int MouseX, int pnlMainY)
        {
            int intDistance = Math.Abs(MouseX - pnlMainY);
            Double dbDistance = Convert.ToDouble(intDistance);
            return dbDistance / 200;

        }

        private void timer1_Tick(object sender, EventArgs e, Form fm)
        {
            int MouseY = Cursor.Position.Y;
            int FormY = fm.Location.Y;
            fm.Opacity = Distance(MouseY, FormY);
            if (MouseY <= (fm.Location.Y + fm.Height) && (MouseY >= fm.Location.Y))
            {
                fm.Opacity = 0;
            }
            else if (MouseY > (fm.Location.Y + fm.Height))
            {
                fm.Opacity = 0.6;
            }
        }
    }
}
