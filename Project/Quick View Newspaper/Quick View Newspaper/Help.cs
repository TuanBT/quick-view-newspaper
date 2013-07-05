using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;

namespace Quick_View_Newspaper
{
    public partial class Help : Form
    {
        //Khai báo list chứa image
        //string[] strListImage = { "images\\Help0.png", "images\\Help1.png", "images\\Help2.png", "images\\Help3.png", "images\\Help4.png", "images\\Help5.png" };
        Image[] strListImage = { Properties.Resources.Help0, Properties.Resources.Help1, Properties.Resources.Help2, Properties.Resources.Help3, Properties.Resources.Help4, Properties.Resources.Help5};
        //Khai báo list hướng dẫn
        string[] stringHelp = { "Bước 1: Khởi động chương trình và chờ nạp dữ liệu", 
                                "Bước 2: Sau khi nạp dữ liệu chương trình sẽ có giao diện như bên dưới. Ấn Alt để ẩn", 
                                "Bước 3: Khi rê chuột vào tiêu đề bài báo sẽ hiện ra thông tin chi tiết của bài báo",
                                "Bước 4: Click chuột tiêu đề sẽ hiện một cửa sổ chi tiết, mỗi lần chỉ mở được một cửa sổ",
                                "Bước 5: Mở Tùy chọn bên góc phải. Ấn giữ Ctrl để di chuyển lên xuống.",
                                "Bước 6: Click chuột phải để đổi. Ấn Ctrl+chuột phải để chọn trong list."};
        int i = 0;
        public Help()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //Lấy đường dẫn trong list
            picHelp.Image = strListImage[i + 1];
            //picHelp.ImageLocation = strListImage[i + 1];
            //Lấy nội dung trong list
            txtHelp.Text = stringHelp[i + 1];
            i++;
            btnPre.Enabled = true;
            //Kiểm tra xem nếu đến cuối list thì btnNext enabled là false
            if (i == (strListImage.Length-1))
            {
                btnNext.Enabled = false;
            }
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            //Lấy đường dẫn trong list
            picHelp.Image = strListImage[i - 1];
            //Lấy nội dung trong list
            txtHelp.Text = stringHelp[i - 1];
            i--;
            btnNext.Enabled = true;
            //Kiểm tra nếu đầu list thì btnPre enabled là false
            if (i == 0)
            {
                btnPre.Enabled = false;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //Khởi tạo đối tượng MailMessage
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            //Mail sẽ gửi
            mail.From = new MailAddress("quickviewnewspaper@gmail.com");
            //Địa chỉ nhận mail
            mail.To.Add("bttvn.4t@gmail.com");
            mail.Subject = "Report Quick View Newspaper by" + txtName.Text;
            mail.Body = txtContent.Text;
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("quickviewnewspaper", "12345678ss");
            SmtpServer.EnableSsl = true;
            MessageBox.Show("Đã gửi mail");
            txtName.Text = "";
            txtContent.Text = "";
            SmtpServer.Send(mail);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
