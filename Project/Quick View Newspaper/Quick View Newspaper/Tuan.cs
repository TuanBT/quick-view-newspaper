using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Quick_View_Newspaper
{
    class Tuan
    {
        #region Khai báo biến
        //List chứa các label
        public List<Label> lblList = new List<Label>();

        //List chứa các tên báo
        public List<string> listNews = new List<string>();

        //List chứa các thể loại và cũng là link
        public List<string> listLinkRSS = new List<string>();

        //List chứa tên các thể loại tồn tại trong database
        public List<string> listCat = new List<string>(); 

        //Các link lần lượt chứa các nội dung của các thể loại hoặc các link RSS
        public List<string> listTitle = new List<string>();
        public List<string> listDescription = new List<string>();
        public List<string> listLink = new List<string>();
        public List<string> listPubDate = new List<string>();
        public List<string> listImage = new List<string>();

        //Timer dùng để xác định việc di chuyển của các label
        Timer tmrRunLabelOnPanel = new Timer();

        //Tooltip dùng để hiện thị nội dung chi tiết của một tin tức
        ToolTip toolTip = new ToolTip();

        SQLiteDatabase db = new SQLiteDatabase();
        RSSRead read = new RSSRead();
        List<RSSInfo> rss = new List<RSSInfo>();

        //Biến xác định tọa độ X của hộp chứa các label
        private int EndLayoutX = 0;
        //Biến xác định tọa độ X khi label chạy, và giá trị này thay đổi theo speedLabel
        int PointX = 0;
        //Quyết định tốc độ nhảy của label run, càng cao thì mỗi bước nhảy càng xa (px)
        private int speedLabel;
        //Giá trị mặc định của nhảy label, càng cao càng xa
        private int defauljumpLabel = 1;
        //Tên báo
        public int newsIndex = 0;
        //Tên thể loại
        public int rSSIndex = -1;
        //Nơi các label được đặt vào
        private Panel pnl;
        //Biến font size
        private int fontSize = 10;
        //Biến tên font
        private string fontName = "Tahoma";
        #endregion

        #region setget
        public int SpeedLabel
        {
            get { return speedLabel; }
            set { speedLabel = value; }
        }

        public string FontName
        {
            get { return fontName; }
            set { fontName = value; }
        }

        public int FontSize
        {
            get { return fontSize; }
            set { fontSize = value; }
        }
        #endregion

        //Biến dùng để xem quá trình chạy label trong timer đã xong chưa 
        //private bool runningFlag = false;

        /// <summary>
        /// Hàm chạy chính dùng để gọi từ bên ngoài vào
        /// </summary>
        /// <param name="pnl"></param>
        /// <param name="newName"></param>
        /// <param name="catName"></param>
        public void RUN(Panel pnl, Label newName, Label catName)
        {
            //Xác định panel
            this.pnl = pnl;
            //Set các giá trị mặc định cho tootip
            SetToolTip();
            //Thời gian di chuyển, số càng cao di chuyển càng chậm
            tmrRunLabelOnPanel.Interval = 10;
            tmrRunLabelOnPanel.Start();
            tmrRunLabelOnPanel.Tick += new EventHandler((sender, e) => RunLabelOnPanel_Tick(sender, e, newName, catName));

            //Lấy tên các báo từ database
            GetNewsFromDatabase();

            //Lấy tên các thể loại từ database
            GetCatFromDatabase();

            Run(newName, catName);
        }

        /// <summary>
        /// Click chuyển báo tới. Xóa label cũ và chuyển báo
        /// </summary>
        /// <param name="newName"></param>
        /// <param name="catName"></param>
        public void NextNews_Click(Label newName, Label catName)
        {
            RemoveLabel();
            newsIndex++;
            Run(newName, catName);
        }


        /// <summary>
        /// Click chuyển thể loại mới (Tức RSS mới). Chuyển theo kiểu tăng tốc
        /// </summary>
        /// <param name="newName"></param>
        /// <param name="catName"></param>
        public void NextRSS_Click(Label newName, Label catName)
        {
            //Tốc độ để chạy label. Đặt cao là để chuyển cho nhanh
            speedLabel = 500;
        }

        /// <summary>
        /// Hàm chạy lần lượt các tiêu đề vô tận, mỗi lần chuyển một RSS thì phần mềm sẽ kết nối mạng và trả lại kết quả cho biến.
        /// </summary>
        /// <param name="newName"></param>
        /// <param name="catName"></param>
        public void Run(Label newName, Label catName)
        {
            //Đặt một lệnh thông báo là đang Load ở đây để báo hiệu là chương trình đang nạp dữ liệu
            try
            {
                speedLabel = defauljumpLabel;
                //Gọi tờ báo tiếp theo
                rSSIndex++;
                //Chạy hết các báo
                if (newsIndex <= listNews.Count - 1)
                {
                    //Lấy RSS từ báo và lưu vào listLinkRSS
                    GetRSSFormNews(listNews[newsIndex]);
                    //Nếu có tồn tại thể loại, chạy hết các thể loại
                    if (rSSIndex <= listLinkRSS.Count - 1)
                    {
                        //Nạp dữ liệu vào các list theo thể loại (1 link RSS)
                        GetDataFormRSS(listLinkRSS[rSSIndex]);
                        //Nạp title vào cho các label
                        GetListToLabel(listTitle);
                        //Xác định tọa độ X của panel đang được set
                        EndLayoutX = pnl.Location.X + pnl.Width;
                        //Ghi lại điểm đầu của label là cuối panel để phục vụ chạy từ lề phải sang trái
                        PointX = EndLayoutX;
                        //Khởi động lại timer chạy label
                        tmrRunLabelOnPanel.Enabled = true;
                        //Trả tên lên label để test
                        newName.Text = listNews[newsIndex];
                        //Trả tên thể loại bằng việc sử dụng hàm lấy index từ chuỗi link RSS, qua đó tìm ra chỉ số
                        int indexCat = GetIndexOfCatId(listLinkRSS[rSSIndex]);
                        //Vì list lưu từ 0 nên -1 để khớp index so với database
                        catName.Text = listCat[indexCat - 1];
                    }
                    //Nếu duyệt RSS hết list thì set lại ban đầu, để tiếp tục chuyển RSS khác, hoặc chuyển báo khác thì nó set lại 0
                    else
                    {
                        rSSIndex = -1;
                        newsIndex++;
                        Run(newName, catName);
                    }
                }
                //Nếu việc đếm đã đếm hết tiêu đề thì đếm sẽ reset lại, vì đã hết kho tin
                else
                {
                    newsIndex = 0;
                    rSSIndex = -1;
                    Run(newName, catName);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            //Đặt một lệnh thông báo ở đây để biết quá trình nạp dữ liệu vào đã xong
        }


        private int i = 0;
        /// <summary>
        /// Timer chạy khi đến giờ, dùng để di chuyển các label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eArgs"></param>
        public void RunLabelOnPanel_Tick(object sender, EventArgs eArgs, Label newName, Label catName)
        {
            //Nếu label mà chưa chạm đường biên thì true, tức là chỉ khi nào chạy hết label thì If này chạy tiếp
            //Mỗi lần thời gian chạy thì hàm này lại được gọi và đếm lại
            //Thời gian càng lớn chạy càng nhanh
            PointX -= speedLabel;
            if (!GetLocationListLabel(PointX))
            {
                //Đến đây thì tức là list label đã chạy hết qua màn hình
                //Set lại label về điểm đầu
                PointX = EndLayoutX;
                //Tạm dừng đồng hồ
                tmrRunLabelOnPanel.Enabled = false;
                //Gọi lại quá trình nạp dữ liệu
                Run(newName, catName);
            }
            //Trong quá trình chạy thì do chưa đạt yêu cầu label chạy tới cuối Panel pnl nên finishFlag vẫn mang giá trị false
        }

        //Hàm trả về chỉ số của thể loại (CatId) thông qua việc biết chuỗi link RSS
        public int GetIndexOfCatId(string RSSLink)
        {
            int IndexOfCatId = 0;
            db = new SQLiteDatabase();
            DataTable recipe;
            //Chuỗi trả về một bảng có chứa dữ liệu tên các thể loại
            String query = "SELECT CatId  FROM tblRSS WHERE (RSSLink=\"" + RSSLink + "\")";
            try
            {
                recipe = db.GetDataTable(query);
                foreach (DataRow r in recipe.Rows)
                {
                    IndexOfCatId = Convert.ToInt32(r["CatId"].ToString());
                }
                return IndexOfCatId;
            }
            catch (Exception fail)
            {
                String error = "The following error has occurred:\n\n";
                error += fail.Message.ToString() + "\n\n";
                MessageBox.Show(error);
                return IndexOfCatId;
            }
        }

        /// <summary>
        /// Lấy list tên các thể loại từ data base đưa vào biến listCat
        /// </summary>
        public void GetCatFromDatabase()
        {
            try
            {
                db = new SQLiteDatabase();
                DataTable recipe;
                //Chuỗi trả về một bảng có chứa dữ liệu tên các thể loại
                String query = "SELECT * FROM tblCategory";
                recipe = db.GetDataTable(query);
                foreach (DataRow r in recipe.Rows)
                {
                    listCat.Add(r["CatName"].ToString());
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
        /// Lấy tên các báo và add vào list tên các báo
        /// </summary>
        public void GetNewsFromDatabase()
        {
            try
            {
                db = new SQLiteDatabase();
                DataTable recipe;
                //Chuỗi trả về một bảng có chứa dữ liệu tên các báo
                String query = "SELECT * FROM tblNewspaper";
                recipe = db.GetDataTable(query);
                foreach (DataRow r in recipe.Rows)
                {
                    listNews.Add(r["NewName"].ToString());
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
                String s = "SELECT r.RSSLink FROM tblNewspaper n JOIN tblRSS r " +
                           "ON n.NewId = r.NewId WHERE n.NewId " +
                           "IN (SELECT NewId FROM tblNewspaper WHERE NewName =\"" + strNews + "\")";
                String query = s;
                recipe = db.GetDataTable(query);
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
        public void GetDataFormRSS(string rssLink)
        {
            listTitle.Clear();
            listDescription.Clear();
            listLink.Clear();
            listPubDate.Clear();
            listImage.Clear();

            rss = read.GetListRSS(rssLink);

            if (rss != null)
            {
                foreach (RSSInfo ri in rss)
                {
                    listTitle.Add(ri.Title);
                    listDescription.Add(ri.Description);
                    listLink.Add(ri.Link);
                    listPubDate.Add(ri.PubDate);
                    listImage.Add(ri.Image);
                }
            }
            else
            {
                listTitle.Add("");
                listDescription.Add("");
                listLink.Add("");
                listPubDate.Add("");
                listImage.Add("");
            }
        }

        public string ContentOfOneTitle(int index)
        {
            string content = "";
            string title = listTitle[index];

            string descrition = HtmlRemoval.StripTagsCharArray(listDescription[index]);
            string pubDate = listPubDate[index];
            string link= listLink[index];
            string image=listImage[index];
            content = "\n"+title + "\n\n" + descrition + "\n\n" + pubDate + "\n\n" + link + "\n\n" + image;
            return content;
        }

        /// <summary>
        /// Thêm dữ liệu từ listString vào các label để hiển thị
        /// </summary>
        /// <param name="listString">List string chứa nội dung về tile....</param>
        public void GetListToLabel(List<string> listString)
        {
            //i dùng đề xác định chỉ số
            int i = -1;
            Label lbl = new Label();
            lblList.Clear();
            if (listString.Count <= 0) return;
            else
            {
                foreach (string str in listString)
                {
                    i++;
                    lbl = new Label();
                    //Set text cho các label
                    lbl.Text = str+"  ---";
                    //Add tooltip vào một label
                    toolTip.SetToolTip(lbl, ContentOfOneTitle(i));
                    //Add label vừa tạo vào list  label
                    lblList.Add(lbl);
                }
            }
        }

        /// <summary>
        /// Hiển thị nội dung thông qua Tooltip khi mà rê chuột vào label
        /// </summary>
        public void SetToolTip()
        {
            //Xuất hiện mượt mà
            toolTip.UseFading = true;
            //Sử dụng hiệu ứng động
            toolTip.UseAnimation = true;
            //Lựa chọn tip kiểu bo tròn hoặc vuông
            toolTip.IsBalloon = true;
            toolTip.ShowAlways = true;
            //Thời gian hiển thị sau khi xuất hiện. 
            toolTip.AutoPopDelay = 30*60*1000;
            //Thời gian chờ xuất hiện lúc rê chuột vào
            toolTip.InitialDelay = 0;
            //Thời gian để hiển thị khi chuyển tới đối tượng mới
            toolTip.ReshowDelay = 0;
            //Tiêu đề của tooltip
            toolTip.ToolTipTitle = "Nội dung:";
        }

        /// <summary>
        /// Add một label lbl vào Panel pnl rồi add nó vào panel pnl với vị trí (x,y)
        /// </summary>
        /// <param name="lbl"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        void MakeLabel(Label lbl, int x)
        {
            pnl.Controls.Add(lbl);
            lbl.Font = new Font("Tahoma",fontSize);
            //Tọa độ Y để nằm được chính giữa panel
            int y =(pnl.Height - lbl.Height)/2;
            lbl.AutoSize = true;
            lbl.Location = new Point(x, y);
            lbl.BorderStyle = BorderStyle.None;
        }

        /// <summary>
        /// Remove label ra khỏi panel khi đã sử dụng xong
        /// </summary>
        void RemoveLabel()
        {
            for (i = 0; i < lblList.Count; i++)
            {
                pnl.Controls.Remove(lblList[i]);
            }
        }

        /// <summary>
        /// Đặt list label vào trong một panel, có điểm xuất phát đầu tiên là (StartX,StartY) và chạy cho tới khi hết biên Panel pnl
        /// </summary>
        /// <param name="startX"></param>
        /// <param name="startY"></param>
        public bool GetLocationListLabel(int startX)
        {
            bool result = true;
            //Xác định vị trí startY sao cho label nằm giữa được panel


            if (lblList.Count > 0)
            {
                MakeLabel(lblList[0], startX);
                int EndX = 0;
                int i = 1;
                for (i = 1; i < lblList.Count; i++)
                {
                    //Lấy toa độ X của đối tượng trước
                    EndX = lblList[i - 1].Location.X + lblList[i - 1].Width;
                    MakeLabel(lblList[i], EndX);
                }
                //Nếu label cuối cùng chạm mốc
                if (EndX + lblList[i - 1].Width <= 0)
                {
                    //MessageBox.Show("Đã chạy hết cuối hàng!!!");
                    RemoveLabel();
                    lblList.Clear();
                    result = false;
                }
            }
            return result;
        }
    }
}
