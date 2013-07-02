using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Quick_View_Newspaper
{
    public class Sinh : Form
    {
        private int TogMove;
        private int MValX;
        private int MValY;
        int padding = 1;
        Timer tmr;
        public NotifyIcon notifyIcon;
        public ContextMenuStrip contextMenu;
        public Form frm;
        private Panel pnlOption;
        private Panel pnlMain;
        private PictureBox picOptOpen;

        public void CALL(NotifyIcon notifyIcon, ContextMenuStrip contextMenu, Form frm, Panel pnlOption, Panel pnlMain, PictureBox picOptOpen)
        {
            this.frm = frm;
            this.pnlMain = pnlMain;
            this.pnlOption = pnlOption;
            this.notifyIcon = notifyIcon;
            this.contextMenu = contextMenu;
            this.picOptOpen = picOptOpen;
            InitializeContextMenu();
            LocationForm();
            SetOptionPanel();
            Notify();
            MoveForm();
        }


        /// <summary>
        /// Set location form
        /// </summary>
        public void LocationForm()
        {

            int nTaskBarHeight = Screen.PrimaryScreen.Bounds.Bottom -
                                             Screen.PrimaryScreen.WorkingArea.Bottom;

            Rectangle workingArea = Screen.GetWorkingArea(frm);
            frm.Location = new Point(0, workingArea.Bottom - frm.Size.Height + nTaskBarHeight);
            frm.TopMost = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            //Kích thước của from ban đầu
            frm.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, pnlMain.Height);
            pnlMain.Width = frm.Width;
        }

        /// <summary>
        /// Set vị trí panel option theo vị trí và độ lớn của panel main
        /// </summary>
        public void SetOptionPanel()
        {
            pnlOption.Location = new Point(pnlMain.Location.X + pnlMain.Width, pnlMain.Location.Y);
            pnlOption.Size= new Size(pnlMain.Width,pnlMain.Height);
        }

        /// <summary>
        /// Điều kiện mở panel
        /// </summary>
        public void OpenTick()
        {
            if (pnlOption.Location.X > pnlMain.Width * 0.11)
            {
                pnlOption.Location = new Point(pnlOption.Location.X - padding, pnlOption.Location.Y);
                padding += 3;
            }
            else if (pnlOption.Location.X > pnlMain.Location.X)
            {
                int pad = 3;
                pnlOption.Location = new Point(pnlOption.Location.X - pad, pnlOption.Location.Y);

            }

        }

        /// <summary>
        /// Điều kiện đóng panel
        /// </summary>
        public void CloseTick()
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
        public void Open()
        {
            tmr = new Timer();
            tmr.Interval = 10;
            tmr.Start();
            tmr.Tick += new System.EventHandler(Open_Tick);
        }
        /// <summary>
        /// Event mở panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eArgs"></param>
        /// <param name="pnlOption"></param>
        /// <param name="pnlMain"></param>
        public void Open_Tick(object sender, EventArgs eArgs)
        {
            if (pnlOption.Location.X <= pnlMain.Location.X)
            {
                tmr.Stop();
                padding = 1;
            }
            OpenTick();
        }

        /// <summary>
        /// Thời gian đóng panel
        /// </summary>
        public void Close()
        {
            tmr = new Timer();
            tmr.Stop();
            tmr.Interval = 10;
            tmr.Start();
            tmr.Tick += new System.EventHandler(Close_Tick);

        }

        /// <summary>
        /// Event đóng panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eArgs"></param>
        public void Close_Tick(object sender, EventArgs eArgs)
        {
            if (pnlOption.Location.X > pnlMain.Location.X + pnlMain.Width)
            {
                tmr.Stop();
                padding = 1;
                SetOptionPanel();
            }
            CloseTick();
        }

        public void Notify()
        {
            notifyIcon.Visible = true;
        }

        private void InitializeContextMenu()
        {
            //MenuItem[] menuList = new MenuItem[]{
            //    new MenuItem("Sign In"),
            //    new MenuItem("Get Help"), 
            //    new MenuItem("Open")};
            ToolStripItem item2 = contextMenu.Items.Add("About ");
            ToolStripItem item = contextMenu.Items.Add("Exit ");
            notifyIcon.ContextMenuStrip = contextMenu;
            //ContextMenu clickMenu = new ContextMenu(menuList);
            //notifyIcon.ContextMenu = clickMenu;
            item2.Click += new EventHandler(item2_Click);
            item.Click += new EventHandler(item_Click);

            // Associate the event-handling method with  
            // the NotifyIcon object's click event.
            notifyIcon.MouseClick += new MouseEventHandler(notifyIcon_MouseClick);
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                notifyIcon.ContextMenuStrip.Show(Cursor.Position);
            }
        }




        // When user clicks the left mouse button display the shortcut menu.   
        // Use the SystemInformation.PrimaryMonitorMaximizedWindowSize property 
        // to place the menu at the lower corner of the screen.

        private void item_Click(object sender, System.EventArgs e)
        {
            frm.Close();
        }

        private void item2_Click(object sender, System.EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }

        public void MoveForm()
        {
            picOptOpen.MouseDown += new MouseEventHandler(picOptOpen_MouseDown);
            picOptOpen.MouseUp += new MouseEventHandler(picOptOpen_MouseUp);
            picOptOpen.MouseMove += new MouseEventHandler(picOptOpen_MouseMove);
        }

        private void picOptOpen_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = 0;
            MValY = e.Y;
        }

        private void picOptOpen_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }
        private void picOptOpen_MouseMove(object sender, MouseEventArgs e)
        {
            int nTaskBarHeight = Screen.PrimaryScreen.Bounds.Top -
                                            Screen.PrimaryScreen.WorkingArea.Top;
            Rectangle workingArea = Screen.GetWorkingArea(frm);
           // frm.Location = new Point(0, workingArea.Bottom - frm.Size.Height + nTaskBarHeight);
            if (TogMove == 1)
            {
                if (MousePosition.Y - MValY < nTaskBarHeight)
                {
                    frm.Location = new Point(0, workingArea.Bottom - frm.Size.Height + nTaskBarHeight);
                }
                else
                {
                    frm.SetDesktopLocation(0, MousePosition.Y - MValY);
                }
                
            }
        }


    }
}
