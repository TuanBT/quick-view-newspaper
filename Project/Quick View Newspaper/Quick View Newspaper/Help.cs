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
        string[] strListImage = { "images\\Help0.png", "images\\Help1.png", "images\\Help2.png", "images\\Help3.png", "images\\Help4.png", "images\\Help5.png" };
        //Khai báo list hướng dẫn
        string[] stringHelp = { "Bước 1: Khởi động chương trình và chờ nạp dữ liệu", 
                                "Bước 2: Sau khi nạp dữ liệu chương trình sẽ có giao diện như bên dưới", 
                                "Bước 3: Khi rê chuột vào tiêu đề bài báo sẽ hiện ra thông tin chi tiết của bài báo",
                                "Bước 4: Khi click chuột vào tiêu đề bài báo sẽ dẫn tới trang nguồn bài báo",
                                "Bước 5: Click vào mũi tên bên góc phải sẽ mở ra thanh tùy chỉnh tại đây bạn có thể tùy chỉnh theo ý muốn, mọi thay đổi sẽ được lưu lại cho đến khi nhấn nút reset",
                                "Bước 6: Khi muốn thay đổi đầu báo hoặc thể loại thì bạn click vào tiêu đề hoặc thể loại"};
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
            picHelp.ImageLocation = strListImage[i + 1];
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
            picHelp.ImageLocation = strListImage[i - 1];
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
    }
}
