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
        private Label lbl;
        private int flag = 1;
        private int TogMove = 0;
        private int MValX;
        private int MValY;
        private Label lblTitle;
        private Label lblCat;
        private ComboBox cbbCatName;
        private ComboBox cbbNewsName;
        int padding = 1;
        Timer tmr;
        public NotifyIcon notifyIcon;
        public ContextMenuStrip contextMenu;
        public Form frm;
        private Panel pnlOption;
        private Panel pnlMain;
        private Panel pnlRun;
        private PictureBox picOptOpen;

        /// <summary>
        /// Xu li tat cac method trong ham call
        /// </summary>
        /// <param name="notifyIcon"></param>
        /// <param name="contextMenu"></param>
        /// <param name="frm"></param>
        /// <param name="pnlOption"></param>
        /// <param name="pnlMain"></param>
        /// <param name="picOptOpen"></param>
        public void CALL(NotifyIcon notifyIcon, ContextMenuStrip contextMenu, Form frm, Panel pnlOption, Panel pnlMain, PictureBox picOptOpen,
            Panel pnlRun, Label lblTitle, Label lblCat, ComboBox cbbCatName, ComboBox cbbNewsName)
        {
            this.frm = frm;
            this.pnlMain = pnlMain;
            this.pnlOption = pnlOption;
            this.notifyIcon = notifyIcon;
            this.contextMenu = contextMenu;
            this.picOptOpen = picOptOpen;
            this.pnlRun = pnlRun;
            this.lblTitle = lblTitle;
            this.lblCat = lblCat;
            this.cbbCatName = cbbCatName;
            this.cbbNewsName = cbbNewsName;
            InitializeContextMenu();
            LocationForm();
            SetOptionPanel();
            Notify();
            MoveForm();
        }


        /// <summary>
        /// Vị trí form khi chương trình chạy
        /// </summary>
        public void LocationForm()
        {

            int nTaskBarHeight = Screen.PrimaryScreen.Bounds.Bottom -
                                             Screen.PrimaryScreen.WorkingArea.Bottom;
            Rectangle workingArea = Screen.GetWorkingArea(frm);
            //Vị trí của form
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
            if ((pnlOption.Location.X == pnlMain.Location.X) && (pnlOption.Location.Y == pnlMain.Location.Y))
            {
                pnlOption.Size = new Size(pnlMain.Width, pnlMain.Height);
            }
            else
            {
                pnlOption.Location = new Point(pnlMain.Location.X + pnlMain.Width, pnlMain.Location.Y);
                pnlOption.Size = new Size(pnlMain.Width, pnlMain.Height);
            }
                
        }

        /// <summary>
        /// Điều kiện mở panel
        /// </summary>
        public void OpenTick()
        {
            //Xét tọa độ X pnlOption > độ rộng pnlMain.Width* 0.11
            if (pnlOption.Location.X > pnlMain.Width * 0.11)
            {
                pnlOption.Location = new Point(pnlOption.Location.X - padding, pnlOption.Location.Y);
                padding += 3;
            }
            //Xét tọa độ X pnlOption > tọa độ X pnlMain
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
            //Xét tọa X pnlOption < tọa độ X pnlMain + độ rộng pnlMain
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
            //Xét tọa độ X pnlOption <= tọa độ X pnlMain
            if (pnlOption.Location.X <= pnlMain.Location.X)
            {
                tmr.Stop();
                padding = 1;
                pnlOption.Location = new Point(pnlMain.Location.X, pnlMain.Location.Y);
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
            //Xét tọa độ X pnlOption > tọa  độ X pnlMain + độ rộng pnlMain
            if (pnlOption.Location.X > pnlMain.Location.X + pnlMain.Width)
            {
                tmr.Stop();
                padding = 1;
                pnlOption.Location = new Point(pnlMain.Location.X + pnlMain.Width, pnlMain.Location.Y);
            }
            CloseTick();
        }

        /// <summary>
        /// Xuất hiện notifyicon khi chương trình chạy
        /// </summary>
        public void Notify()
        {
            notifyIcon.Visible = true;
        }

        /// <summary>
        /// Add cac item vao contextmenu
        /// </summary>
        private void InitializeContextMenu()
        {
            ToolStripItem item3 = contextMenu.Items.Add("Help ");
            ToolStripItem item2 = contextMenu.Items.Add("About ");
            ToolStripItem item = contextMenu.Items.Add("Exit ");
            notifyIcon.ContextMenuStrip = contextMenu;
            item3.Click += new EventHandler(item3_Click);
            item2.Click += new EventHandler(item2_Click);
            item.Click += new EventHandler(item_Click);
            notifyIcon.MouseClick += new MouseEventHandler(notifyIcon_MouseClick);
        }

        /// <summary>
        /// Sự kiện click chuột của notifyicon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            //Nếu click chuột phải xuất hiện các item của contextmenu
            if (e.Button == MouseButtons.Right)
            {
                notifyIcon.ContextMenuStrip.Show(Cursor.Position);
            }
        }

        /// <summary>
        /// Sự kiện click item "Exit" thoát chương trình
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void item_Click(object sender, System.EventArgs e)
        {
            frm.Close();
        }

        /// <summary>
        /// Sự kiện click item2 "About" xem about của phần mềm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void item2_Click(object sender, System.EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }

        /// <summary>
        /// Sự kiện click item3 "Help" xem help của phần mềm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void item3_Click(object sender, System.EventArgs e)
        {
            Help help = new Help();
            help.Show();
        }

        /// <summary>
        /// Xử lý di chuyển form
        /// </summary>
        public void MoveForm()
        {
            frm.KeyDown += frm_KeyDown;
            picOptOpen.MouseDown += new MouseEventHandler(picOptOpen_MouseDown);
            picOptOpen.MouseUp += new MouseEventHandler(picOptOpen_MouseUp);
            picOptOpen.MouseMove += new MouseEventHandler(picOptOpen_MouseMove);
            pnlRun.MouseDown += new MouseEventHandler(pnlRun_MouseDown);
            pnlRun.MouseUp += new MouseEventHandler(pnlRun_MouseUp);
            pnlRun.MouseMove += new MouseEventHandler(pnlRun_MouseMove);
            lblTitle.MouseClick += new MouseEventHandler(lblTitle_MouseClick);
            lblCat.MouseClick += new MouseEventHandler(lblCat_MouseClick);
        }

        //Sự kiện ấn phím Ctrl
        void frm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                flag = 0;
            }
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

        /// <summary>
        /// Sự kiện dj chuyển chuột di chuyển form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picOptOpen_MouseMove(object sender, MouseEventArgs e)
        {
            //Trên taskbar
            if (frm.Location.Y < 0)
            {
                frm.Location = new Point(0, 0);
            }
            //dưới taskbar
            if (frm.Location.Y + frm.Size.Height > Screen.PrimaryScreen.WorkingArea.Height)
            {
                frm.Location = new Point(0, Screen.PrimaryScreen.WorkingArea.Height - frm.Size.Height);
            }
            //Nếu nhấn phìm Ctrl di chuyển form
            if (flag == 0)
            {
                if (TogMove == 1)
                {
                    frm.SetDesktopLocation(0, MousePosition.Y - MValY);
                }
            }
        }

        private void pnlRun_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = 0;
            MValY = e.Y;
        }

        private void pnlRun_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        /// <summary>
        /// Sự kiện dj chuyển chuột di chuyển form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlRun_MouseMove(object sender, MouseEventArgs e)
        {
            //Trên taskbar
            if (frm.Location.Y < 0)
            {
                frm.Location = new Point(0, 0);
            }
            //dưới taskbar
            if (frm.Location.Y + frm.Size.Height > Screen.PrimaryScreen.WorkingArea.Height)
            {
                frm.Location = new Point(0, Screen.PrimaryScreen.WorkingArea.Height - frm.Size.Height);
            }
            //Nếu nhấn phìm Ctrl di chuyển form
            if (flag == 0)
            {
                if (TogMove == 1)
                {
                    frm.SetDesktopLocation(0, MousePosition.Y - MValY);
                }
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Sinh
            // 
            this.ClientSize = new System.Drawing.Size(404, 261);
            this.Name = "Sinh";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        private void lblTitle_MouseClick(object sender, MouseEventArgs e)
        {
            if(flag == 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    cbbNewsName.Visible = true;
                }
            }
        }

        private void lblCat_MouseClick(object sender, MouseEventArgs e)
        {
            if (flag == 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    cbbCatName.Visible = true;
                }
            }
        }


    }
}
