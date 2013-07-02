using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Quick_View_Newspaper
{
    public partial class Form1 : Form
    {
        Sinh s = new Sinh();
        Tuan t = new Tuan();
        Kha k = new Kha();

        //t.FontSize là biến để điều khiển font chữ chạy tin. Ví dụ: t.FontSize=15;
        //t.SpeedLabel là biến dùng để điều khiển tốc độ chạy tin. Mặc định: t.SpeedLabel=1
        //s.SetOptionPanel() là hàm dùng để set lại độ rộng và vị trí của panel Option theo kích thước và vị trí của panel Main
        //setValueOptionToConfig(string fontSize, string speed, string opacity) dùng để ghi lại Option xuống file. Dấu - để thể hiện không sửa đổi

        public Form1(string args = "")
        {
            InitializeComponent();
            //Lập các giá trị mặc định cho chương trình từ file config ini
            t.setDeafault();
            k.OpacityMouse(this);
            s.CALL(notifyIcon1, contextMenuStrip1, this, pnlOption, pnlMain,picOptOpen);
            //t.RUN(pnlRun, lblTitle, lblCat, cbbNewsName, cbbCatName, lblNoti,args);
            Help h = new Help();
            h.Show();
            this.KeyPreview = true;
        }

        #region Kha sửa
        private void nudOpacity_ValueChanged(object sender, EventArgs e)
        {
            k.ReOpacity(this, Convert.ToInt32(nudOpacity.Value.ToString()));
        }
        #endregion

        #region các nút mà Tuân sử dụng
        private void lblTitle_MouseClick(object sender, MouseEventArgs e)
        {
            t.NextNews_Click();
        }

        private void lblCat_MouseClick(object sender, MouseEventArgs e)
        {
            t.NextRSS_Click();
        }

        private void lblTitle_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lblTitle.Visible = false;
            cbbNewsName.Visible = true;
        }

        private void lblCat_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lblCat.Visible = false;
            cbbCatName.Visible = true;
        }
        private void cbbNewsName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbbNewsName.Visible = false;
            lblTitle.Visible = true;
        }

        private void cbbCatName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbbCatName.Visible = false;
            lblCat.Visible = true;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            t.setDeafault();
        }
        #endregion

        #region Sinh dùng
        private void picOptOpen_MouseClick(object sender, MouseEventArgs e)
        {
            s.Open();
        }

        private void picOptClose_MouseClick(object sender, MouseEventArgs e)
        {
            s.Close();
        }
        #endregion





    }
}
