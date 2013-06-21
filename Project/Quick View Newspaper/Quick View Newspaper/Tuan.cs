using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Quick_View_Newspaper
{
    class Tuan
    {
        public List<Label> lblList = new List<Label>();
        public List<string> kinhTe = new List<string>();
        public List<string> vanHoa = new List<string>();
        public List<string> theThao = new List<string>();
        Timer tmrRunPanel;

        
        public void AddData()
        {
            for (int i = 1; i <= 2; i++)
            {

                kinhTe.Add("Kinh tế " + i);
            }
            for (int i = 1; i <= 5; i++)
            {

                vanHoa.Add("Văn hóa " + i);
            }
            for (int i = 1; i <= 20; i++)
            {

                theThao.Add("Thể thao " + i);
            }
        }

        //List category
       public void AddToLable(List<string> listCategory)
        {
            Label lbl;
            if (listCategory.Count <= 0) return;
            else
            {
                foreach (string str in listCategory)
                {
                    lbl = new Label();
                    lbl.Text = str;
                    lblList.Add(lbl);
                }
            }
        }

        public void Deafault(List<string> listCategory)
        {
            AddData();
            AddToLable(listCategory);
        }

        /// <summary>
        /// Add một label lbl vào Panel pnl rồi add nó vào panel pnl với vị trí (x,y)
        /// </summary>
        /// <param name="pnl"></param>
        /// <param name="lbl"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        void MakeLabel(Panel pnl, Label lbl,int x,int y)
        {
            pnl.Controls.Add(lbl);
            lbl.AutoSize = true;
            lbl.Location = new Point(x, y);
        }
        
        /// <summary>
        /// Đặt list label vào trong một panel, có điểm xuất phát đầu tiên là (StartX,StartY) và chạy cho tới khi hết biên Panel pnl
        /// </summary>
        /// <param name="pnl"></param>
        /// <param name="startX"></param>
        /// <param name="startY"></param>
        public bool put(Panel pnl,int startX, int startY)
        {
            bool result = true;
            MakeLabel(pnl, lblList[0], startX, startY);
            int EndX=0;
            int i = 1;
            for (i=1; i < lblList.Count; i++)
            {
                //Lấy toa độ X của đối tượng trước
                EndX = lblList[i - 1].Location.X + lblList[i - 1].Width;
                MakeLabel(pnl, lblList[i], EndX, startY);
            }
            //Nếu label cuối cùng chạm mốc
            if (EndX + lblList[i - 1].Width == 0)
            {
                //MessageBox.Show("Đã chạy hết cuối hàng!!!");
                lblList.Clear();
                result = false;
            }
            return result;
        }

        private int EndLayoutX = 0;
        int PointX = 0;

        public void RunPanel(Panel pnl)
        {
            tmrRunPanel = new Timer();
            tmrRunPanel.Interval = 10;
            tmrRunPanel.Start();
            Deafault(kinhTe);
            EndLayoutX = pnl.Location.X + pnl.Width;
            PointX = EndLayoutX;
            tmrRunPanel.Tick += new EventHandler((sender, e) => RunPanelEvent(sender, e, pnl));
        }

        public void RunPanelEvent(object sender, EventArgs eArgs, Panel pnl)
        {
            //Nếu label mà chưa chạm đường biên thì true
            if (!put(pnl, PointX--, 0))
            {
                //Nếu chạm rồi thì:
                //Set lại label về điểm đầu
                PointX = EndLayoutX;
                //Chuyển category mới
                Deafault(vanHoa);
            }
        }




    }
}
