using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Quick_View_Newspaper
{
    class Tuan
    {
        public List<Label> lblList = new List<Label>();
        public List<string> listNews = new List<string>();
        public List<string> listLinkRSS = new List<string>();
        public List<string> listTitle = new List<string>();
        public List<string> listDescription = new List<string>();
        public List<string> listLink = new List<string>();
        public List<string> listPubDate = new List<string>();
        public List<string> listImage = new List<string>();

        SQLiteDatabase db = new SQLiteDatabase();
        RSSRead read = new RSSRead();
        List<RSSInfo> rss = new List<RSSInfo>();


        /// <summary>
        /// Lấy các link CSS từ database và lưu vào list listLinkRSS
        /// </summary>
        /// <param name="strNews">Tên báo</param>
        public void GetRSSFormNews(string strNews)
        {
            listLinkRSS.Clear();
            try
            {
                db = new SQLiteDatabase();
                DataTable recipe;
                //Chuỗi này phải trả về được một bảng link các RSS của bảng tblRSS. Phải làm sao nhận giá trị là tên báo
                String query = "SELECT * FROM tblRSS WHERE NewId="+strNews;
                recipe = db.GetDataTable(query);
                // The results can be directly applied to a DataGridView control
                //dgv.DataSource = recipe;
                
                // Or looped through for some other reason
                foreach (DataRow r in recipe.Rows)
                {
                    listLinkRSS.Add(r["RSSLink"].ToString());
                }
            }
            catch (Exception fail)
            {
                String error = "The following error has occurred:\n\n";
                error += fail.Message.ToString() + "\n\n";
                MessageBox.Show(error);
            }
        }


        /// <summary>
        /// Add các dữ liệu lấy được từ rssLink vào các list sẵn có
        /// </summary>
        /// <param name="rssLink">Link RSS hợp lệ</param>
        public void GetDataFormCSS(string rssLink)
        {
            listTitle.Clear();
            listDescription.Clear();
            listLink.Clear();
            listPubDate.Clear();
            listImage.Clear();

            rss = read.GetListRSS(rssLink);

            foreach (RSSInfo ri in rss)
            {
                listTitle.Add(ri.Title);
                listDescription.Add(ri.Description);
                listLink.Add(ri.Link);
                listPubDate.Add(ri.PubDate);
                listImage.Add(ri.Image);
            }
        }

        /// <summary>
        /// Thêm dữ liệu từ listString vào các label để hiển thị
        /// </summary>
        /// <param name="listString">List string chứa nội dung về tile....</param>
        public void GetListToLabel(List<string> listString)
        {
            Label lbl = new Label();
            lblList.Clear();
            if (listString.Count <= 0) return;
            else
            {
                foreach (string str in listString)
                {
                    lbl = new Label();
                    lbl.Text = str;
                    lblList.Add(lbl);
                }
            }
        }

        //Dùng đế test việc add một rssLink sẵn có
        public void Deafault(string rssLink)
        {
            GetDataFormCSS(rssLink);
            GetListToLabel(listTitle);
        }

        /// <summary>
        /// Add một label lbl vào Panel pnl rồi add nó vào panel pnl với vị trí (x,y)
        /// </summary>
        /// <param name="pnl"></param>
        /// <param name="lbl"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        void MakeLabel(Panel pnl, Label lbl, int x, int y)
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
        public bool GetLocationListLabel(Panel pnl, int startX, int startY)
        {
            bool result = true;
            MakeLabel(pnl, lblList[0], startX, startY);
            int EndX = 0;
            int i = 1;
            for (i = 1; i < lblList.Count; i++)
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


        /// <summary>
        /// Chạy đống các label lên panel pnl, và được nhận dữ liệu từ rssLink
        /// </summary>
        /// <param name="pnl"></param>
        /// <param name="rssLink"></param>
        public void RunLabelOnPanel(Panel pnl, string rssLink)
        {
            Timer tmrRunLabelOnPanel = new Timer();
            tmrRunLabelOnPanel.Interval = 10;
            tmrRunLabelOnPanel.Start();
            //Dùng để text
            Deafault(rssLink);
            EndLayoutX = pnl.Location.X + pnl.Width;
            PointX = EndLayoutX;
            tmrRunLabelOnPanel.Tick += new EventHandler((sender, e) => RunRunLabelOnPanel_Tick(sender, e, pnl));
        }

        /// <summary>
        /// Timer chạy khi đến giờ, dùng để di chuyển các label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eArgs"></param>
        /// <param name="pnl"></param>
        public void RunRunLabelOnPanel_Tick(object sender, EventArgs eArgs, Panel pnl)
        {
            //Nếu label mà chưa chạm đường biên thì true
            if (!GetLocationListLabel(pnl, PointX--, 0))
            {
                //Nếu chạm rồi thì:
                //Set lại label về điểm đầu
                PointX = EndLayoutX;
                //Chuyển category mới
                //Deafault(vanHoa);
            }
        }




    }
}
