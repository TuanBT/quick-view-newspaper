using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Quick_View_Newspaper
{
    class Sinh
    {
        int padding = 1;
        Timer Clock;

        /// <summary>
        /// Set location
        /// </summary>
        /// <param name="pnlOption"></param>
        /// <param name="pnlMain"></param>
        public void SetLocationPanel(Panel pnlOption, Panel pnlMain)
        {
            pnlOption.Location = new Point(pnlMain.Location.X + pnlMain.Width, pnlMain.Location.Y);
        }
               
        /// <summary>
        /// Điều kiện mở panel
        /// </summary>
        /// <param name="pnlOption"></param>
        /// <param name="pnlMain"></param>
        public void OpenTick(Panel pnlOption, Panel pnlMain)
        {
            if (pnlOption.Location.X > pnlMain.Width * 0.11)
            {
                pnlOption.Location = new Point(pnlOption.Location.X - padding, pnlOption.Location.Y);
                padding += 3;
            }
            else if (pnlOption.Location.X > pnlMain.Location.X)
            {
                padding = 1;
                pnlOption.Location = new Point(pnlOption.Location.X - padding, pnlOption.Location.Y);
            }

        }

        /// <summary>
        /// Điều kiện đóng panel
        /// </summary>
        /// <param name="pnlOption"></param>
        /// <param name="pnlMain"></param>
        public void CloseTick(Panel pnlOption, Panel pnlMain)
        {
            if (pnlOption.Location.X < (pnlMain.Location.X + pnlMain.Width))
            {
                pnlOption.Location = new Point(pnlOption.Location.X + padding, pnlOption.Location.Y);
                padding += 2;
            }
        }

        /// <summary>
        /// Thời gian thực hiện mở panel
        /// </summary>
        /// <param name="pnlOption"></param>
        /// <param name="pnlMain"></param>
        public void Open(Panel pnlOption, Panel pnlMain)
        {
            Clock = new Timer();
            Clock.Interval = 10;
            Clock.Start();
            Clock.Tick += new EventHandler((sender, e) => Open_Tick(sender, e, pnlOption, pnlMain));
        }
        /// <summary>
        /// Event mở panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eArgs"></param>
        /// <param name="pnlOption"></param>
        /// <param name="pnlMain"></param>
        public void Open_Tick(object sender, EventArgs eArgs, Panel pnlOption, Panel pnlMain)
        {
            if (pnlOption.Location.X == pnlMain.Location.X)
            {
                Clock.Stop();
            }
            OpenTick(pnlOption, pnlMain);
        }

        /// <summary>
        /// Thời gian đóng panel
        /// </summary>
        /// <param name="pnlOption"></param>
        /// <param name="pnlMain"></param>
        public void Close(Panel pnlOption, Panel pnlMain)
        {
            Clock = new Timer();
            Clock.Stop();
            Clock.Interval = 10;
            Clock.Start();
            Clock.Tick += new EventHandler((sender, e) => Close_Tick(sender, e, pnlOption, pnlMain));
        }

        /// <summary>
        /// Event đóng panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eArgs"></param>
        /// <param name="pnlOption"></param>
        /// <param name="pnlMain"></param>
        public void Close_Tick(object sender, EventArgs eArgs, Panel pnlOption, Panel pnlMain)
        {
            if (pnlOption.Location.X > pnlMain.Location.X + pnlMain.Width)
            {
                Clock.Stop();
            }
            CloseTick(pnlOption, pnlMain);
        }

    }
}
