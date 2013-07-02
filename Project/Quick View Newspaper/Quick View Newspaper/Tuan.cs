using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Runtime.InteropServices;
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

        //Combobox chứa tên các báo có trong database
        private ComboBox cbbNewsName = new ComboBox();

        //Combobox chứa tên các thể loại mà mỗi tên báo có được
        private ComboBox cbbCatName = new ComboBox();

        //Biến xác định tọa độ X của hộp chứa các label
        private int EndLayoutX = 0;
        //Biến xác định tọa độ X khi label chạy, và giá trị này thay đổi theo speedLabel
        int PointX = 0;
        //Quyết định tốc độ nhảy của label run, càng cao thì mỗi bước nhảy càng xa (px)
        private int speedLabel;
        //Tên báo
        public int newsIndex = 0;
        //Tên thể loại
        public int rSSIndex = -1;
        //Nơi các label được đặt vào
        private Panel pnl;
        //Biến font size
        private int fontSize;
        //Biến tên font
        private string fontName = "Tahoma";
        //Biến dùng để xác định tên thể loại ứng với mỗi link RSS đang hiện hành. Thường phải dùng với listCat[indexCat - 1];
        private int indexCat;
        //Label newName của form
        private Label newName;
        //Label catName của form
        private Label catName;
        //Label dùng đê thông báo việc nạp dữ liệu
        private Label lblNoti;
        //Chuỗi cho biết vị trí của chương trình lúc khởi chạy, dùng để chương trình khác gọi vào
        private string path;
        //Tên của Database
        private string database = "QVN.s3db";
        //File config ini nhằm lưu trữ các thông số sau lần chạy đầu tiên
        private string fileIniPath;
        //Báo gọi lớp ini
        private Config file;
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
        public void RUN(Panel pnl, Label newName, Label catName, ComboBox cbbNewsName, ComboBox cbbCatName, Label lblNoti, string path)
        {
            //Xác định các biến
            this.pnl = pnl;
            this.catName = catName;
            this.newName = newName;
            this.cbbNewsName = cbbNewsName;
            this.cbbCatName = cbbCatName;
            this.lblNoti = lblNoti;
            this.path = path;
            //Đường dẫn tới ngay nơi file ini
            fileIniPath = Application.StartupPath + "\\QVN_Config.ini";
            //Gán giá trị cho lớp gọi ini
            file = new Config(fileIniPath);
            //Set các giá trị mặc định cho tootip
            SetToolTip();
            //Thời gian di chuyển, số càng cao di chuyển càng chậm
            tmrRunLabelOnPanel.Interval = 10;
            tmrRunLabelOnPanel.Start();
            tmrRunLabelOnPanel.Tick += new EventHandler(RunLabelOnPanel_Tick);
            //Lấy tên các báo từ database
            GetNewsFromDatabase();
            //Lấy tên các thể loại từ database
            GetCatFromDatabase();
            //Nạp tên các thể loại mà tiêu đề báo này có được vào combobox cbbCatName
            GetCatOfNewsFormDatabase();
            //Khai báo sự kiện khi thay đổi combobox
            cbbNewsName.SelectedIndexChanged += new EventHandler(cbbNewsName_SelectedIndexChanged);
            cbbCatName.SelectedIndexChanged += new EventHandler(cbbCatName_SelectedIndexChanged);
            //Set tốc độ mặc định cho việc chạy label
            //speedLabel = 1;
            Run();
        }

        /// <summary>
        /// Click chuyển báo tới. Xóa label cũ và chuyển báo
        /// </summary>
        public void NextNews_Click()
        {
            RemoveLabel();
            newsIndex++;
            //Nạp tên các thể loại mà tiêu đề báo này có được vào combobox cbbCatName
            GetCatOfNewsFormDatabase();
            Run();
        }


        /// <summary>
        /// Click chuyển thể loại mới (Tức RSS mới). Chuyển theo kiểu tăng tốc
        /// </summary>
        public void NextRSS_Click()
        {
            //Tốc độ để chạy label. Đặt cao là để chuyển cho nhanh
            speedLabel = 500;
        }

        /// <summary>
        /// Hàm chạy lần lượt các tiêu đề vô tận, mỗi lần chuyển một RSS thì phần mềm sẽ kết nối mạng và trả lại kết quả cho biến.
        /// </summary>
        public void Run()
        {
            //Label thông báo việc chương trình đang nạp dữ liệu
            lblNoti.Visible = true;
            try
            {
                //Gọi tờ báo tiếp theo
                rSSIndex++;
                //Set lại giá trị tốc độ khi đã chạy xong báo
                speedLabel = Convert.ToInt32(file.ReadValue("Option C", "Speed"));
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
                        indexCat = GetIndexOfCatId(listLinkRSS[rSSIndex]);
                        //Vì list lưu từ 0 nên -1 để khớp index so với database
                        catName.Text = listCat[indexCat - 1];
                        //Nạp dữ liệu hiện thời từ các label vào combobox
                        cbbNewsName.Text = newName.Text;
                        cbbCatName.Text = catName.Text;
                    }
                    //Nếu duyệt RSS hết list thì set lại ban đầu, để tiếp tục chuyển RSS khác, hoặc chuyển báo khác thì nó set lại 0
                    else
                    {
                        rSSIndex = -1;
                        newsIndex++;
                        //Nạp tên các thể loại mà tiêu đề báo này có được vào combobox cbbCatName
                        GetCatOfNewsFormDatabase();
                        Run();
                    }
                }
                //Nếu việc đếm đã đếm hết tiêu đề thì đếm sẽ reset lại, vì đã hết kho báo có được trong database
                else
                {
                    newsIndex = 0;
                    //Nạp tên các thể loại mà tiêu đề báo này có được vào combobox cbbCatName
                    GetCatOfNewsFormDatabase();
                    rSSIndex = -1;
                    Run();
                }
            }
            catch (Exception e)
            {
                Log.WriteLog("Có vấn đề trong quá trình nạp RSS");
                MessageBox.Show(e.ToString());
            }
            finally
            {
                //Label thông báo biến mất vì đã kết thúc nạp dữ liệu
                lblNoti.Visible = false;
            }
        }

        //Hàm sử lý sự kiện khi thay đổi cbbNewsName. Mỗi lần chọn thì ta có được NewsName
        public void cbbNewsName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Làm sao đó từ NewsName này mà tìm ra được cái newsIndex. Sau đó thay đổi lại cái newsIdex và chạy lại run
            for (int i = 0; i < listNews.Count; i++)
            {
                if (listNews[i] == cbbNewsName.Text)
                {
                    newsIndex = i;
                    break;
                }
            }
            RemoveLabel();
            //Nạp tên các thể loại mà tiêu đề báo này có được vào combobox cbbCatName
            rSSIndex = 0;
            GetCatOfNewsFormDatabase();
            Run();
        }

        //Hàm sử lý sự kiện khi thay đổi cbbCatName. Mỗi lần chọn thì ta có được catName
        public void cbbCatName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //làm sao đó từ catName tìm ra được rSSIndex. Sau đó thay đổi lại cái rSSIndex và chạy lại run
            for (int i = 0; i < listCat.Count; i++)
            {
                if (listCat[i] == cbbCatName.Text)
                {
                    rSSIndex = i-1;
                    break;
                }
            }
            RemoveLabel();
            Run();
        }

        private int i = 0;
        /// <summary>
        /// Timer chạy khi đến giờ, dùng để di chuyển các label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eArgs"></param>
        public void RunLabelOnPanel_Tick(object sender, EventArgs eArgs)
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
                Run();
            }
            //Trong quá trình chạy thì do chưa đạt yêu cầu label chạy tới cuối Panel pnl nên finishFlag vẫn mang giá trị false
        }

        /// <summary>
        /// Hàm trả về chỉ số của thể loại (CatId) thông qua việc biết chuỗi link RSS
        /// </summary>
        /// <param name="RSSLink"></param>
        /// <returns></returns>
        public int GetIndexOfCatId(string RSSLink)
        {
            int IndexOfCatId = 0;
            db = new SQLiteDatabase(path + database);
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
                Log.WriteLog(error);
                return IndexOfCatId;
            }
        }

        /// <summary>
        /// Lấy danh sách các thể loại có ở data base của Báo hiện thời đưa vào combobox
        /// </summary>
        public void GetCatOfNewsFormDatabase()
        {
            try
            {
                db = new SQLiteDatabase(path + database);
                DataTable recipe;
                //Chuỗi trả về một bảng chứa các thể loại mà loại báo (newsIndex+1) hiện hành đang có
                string NewID = (newsIndex + 1).ToString();
                String query = "SELECT c.CatName " +
                               "FROM tblCategory c, tblNewspaper n,tblRSS r " +
                               "WHERE (n.NewId=\"" + NewID + "\")" +
                               "AND(n.NewId=r.NewId)" +
                               "AND(r.CatId=c.CatId)";
                recipe = db.GetDataTable(query);
                cbbCatName.DataSource = recipe;
                cbbCatName.DisplayMember = "CatName";
            }
            catch (Exception fail)
            {
                String error = "The following error has occurred:\n\n";
                error += fail.Message.ToString() + "\n\n";
                MessageBox.Show(error);
                Log.WriteLog(error);
            }
        }

        /// <summary>
        /// Lấy list tên các thể loại từ data base đưa vào biến listCat
        /// </summary>
        public void GetCatFromDatabase()
        {
            try
            {
                db = new SQLiteDatabase(path + database);
                DataTable recipe;
                //Chuỗi trả về một bảng có chứa dữ liệu tên các thể loại
                String query = "SELECT CatName FROM tblCategory";
                recipe = db.GetDataTable(query);
                cbbCatName.DataSource = recipe;
                cbbCatName.DisplayMember = "CatName";
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
                Log.WriteLog(error);
            }
        }


        /// <summary>
        /// Lấy tên các báo và add vào list tên các báo
        /// </summary>
        public void GetNewsFromDatabase()
        {
            try
            {
                db = new SQLiteDatabase(path + database);
                DataTable recipe;
                //Chuỗi trả về một bảng có chứa dữ liệu tên các báo
                String query = "SELECT NewName FROM tblNewspaper";
                recipe = db.GetDataTable(query);
                cbbNewsName.DataSource = recipe;
                cbbNewsName.DisplayMember = "NewName";
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
                Log.WriteLog(error);
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
                db = new SQLiteDatabase(path + database);
                DataTable recipe;
                //Chuỗi này phải trả về được một bảng link các RSS của bảng tblRSS. Phải làm sao nhận giá trị là tên báo
                String query = "SELECT r.RSSLink FROM tblNewspaper n JOIN tblRSS r " +
                           "ON n.NewId = r.NewId WHERE n.NewId " +
                           "IN (SELECT NewId FROM tblNewspaper WHERE NewName =\"" + strNews + "\")";
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
                Log.WriteLog(error);
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

        /// <summary>
        /// Tạo nội dung cho một tooltip dựa vào tiêu để để gắn vào trong tooltip
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public string ContentOfOneTitle(int index)
        {
            string content = "";
            string title = listTitle[index];

            string descrition = HtmlRemoval.StripTagsCharArray(listDescription[index]);
            string pubDate = listPubDate[index];
            string link = listLink[index];
            string image = listImage[index];
            content = "\n" + title + "\n\n" + descrition + "\n\n" + pubDate;
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
                    lbl.Text = str + "  ---";
                    //Add tooltip vào một label
                    toolTip.SetToolTip(lbl, ContentOfOneTitle(i));
                    //Gán id cho label để đánh dấu sự kiện
                    lbl.Tag = i;
                    //Gọi sự kiện click label
                    lbl.Click += new EventHandler(Label_Click);
                    //Gọi sự kiện để chuột vào label
                    lbl.MouseHover += new EventHandler(Label_MouseHover);
                    //Gọi sự kiện chuột ra khỏi label
                    lbl.MouseLeave += new EventHandler(Label_MouseLeave);
                    //Add label vừa tạo vào list  label
                    lblList.Add(lbl);
                }
            }
        }

        /// <summary>
        /// Nơi sử lý sự kiện rê chuột vào các label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Label_MouseHover(object sender, EventArgs e)
        {
            //Với mỗi label được gọi, ta có thể làm gì tùy thích
            int id = (int)((Label)sender).Tag;
            lblList[id].BackColor = Color.Red;
            lblList[id].ForeColor = Color.Yellow;
            tmrRunLabelOnPanel.Enabled = false;
        }

        /// <summary>
        /// Nơi sự lý sự kiện chuột rời khỏi label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Label_MouseLeave(object sender, EventArgs e)
        {
            //Với mỗi label được gọi, ta có thể làm gì tùy thích
            int id = (int)((Label)sender).Tag;
            lblList[id].BackColor = SystemColors.Control;
            lblList[id].ForeColor = Color.Gray;
            tmrRunLabelOnPanel.Enabled = true;
        }

        /// <summary>
        /// Nơi sử lý sự kiện Clik các label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Label_Click(object sender, EventArgs e)
        {
            // Lấy id của label
            int id = (int)((Label)sender).Tag;
            WebBrowserForm wbf = new WebBrowserForm(listLink[id], listNews[newsIndex], listCat[indexCat - 1]);
            //Kiểm tra xem form web đã được mở hay chưa
            if ((Application.OpenForms["WebBrowserForm"] as WebBrowserForm) != null)
            {
                //Vào được đây tức là có một form đang mở. Cần đóng nó lại để mở ra
                //Close form web hiện thời lại
                (Application.OpenForms["WebBrowserForm"] as WebBrowserForm).Close();
            }
            wbf.Show();
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
            toolTip.AutoPopDelay = 30 * 60 * 1000;
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
            lbl.Font = new Font("Tahoma", fontSize);
            //Tọa độ Y để nằm được chính giữa panel
            int y = (pnl.Height - lbl.Height) / 2;
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

        /// <summary>
        /// Dựa vào các thông số trong file config mà set mặc định các giá trị Option
        /// </summary>
        public void setDeafault()
        {
            try
            {
                fontSize = Convert.ToInt32(file.ReadValue("Option", "Font size"));
                speedLabel = Convert.ToInt32(file.ReadValue("Option", "Speed"));
                //Tìm biến độ mờ của kha thả vào
                //k.Opacity = Convert.ToInt32(file.ReadValue("Option", "Opacity"));
            }
            catch (Exception)
            {
                fontSize = 10;
                speedLabel = 1;
                //k.Opacity=????
            }
        }

        /// <summary>
        /// Từ giá trị sửa đổi của config, xây dựng lại Option cho những lần chạy sau
        /// </summary>
        public void GetOption()
        {
            try
            {
                fontSize = Convert.ToInt32(file.ReadValue("Option C", "Font size"));
                speedLabel = Convert.ToInt32(file.ReadValue("Option C", "Speed"));
                //Tìm biến độ mờ của kha thả vào
                //k.Opacity = Convert.ToInt32(file.ReadValue("Option", "Opacity"));
            }
            catch (Exception)
            {
                fontSize = 10;
                speedLabel = 1;
                //k.Opacity=????
            }
        }

        /// <summary>
        /// Đặt giá trị vào lại config. Dấu "-" là không đổi
        /// </summary>
        /// <param name="fontSize"></param>
        /// <param name="speed"></param>
        /// <param name="opacity"></param>
        public void setValueOptionToConfig(string fontSize, string speed, string opacity)
        {
            if (fontSize != "-")
            {
                file.WriteValue("Option", "Font Size", fontSize.ToString());
            }
            if (speed != "-")
            {
                file.WriteValue("Option C", "Speed", speed.ToString());
            }
            if (opacity != "-")
            {
                file.WriteValue("Option C", "Opacity", opacity.ToString());
            }
        }
    }
}