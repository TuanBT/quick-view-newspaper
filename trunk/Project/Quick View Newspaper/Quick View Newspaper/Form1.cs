using System;
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
        //t.setValueOptionToConfig(string fontSize, string speed, string opacity) dùng để ghi lại Option xuống file. Dấu - để thể hiện không sửa đổi

        public Form1(string args)
        {
            InitializeComponent();
            //Ghi registry
            k.RunOpen(Application.StartupPath+"\\");
            //Set option vào file config
            t.setDeafault(nudSize,nudSpeed,nudOpacity);
            //Mờ form khi rê chuột
            k.OpacityMouse(this);
            s.CALL(notifyIcon1, contextMenuStrip1, this, pnlOption, pnlMain,picOptOpen, pnlRun, lblTitle, lblCat, cbbCatName,cbbNewsName);
            t.RUN(pnlRun, lblTitle, lblCat, cbbNewsName, cbbCatName, lblNoti,args);
            this.KeyPreview = true;
            k.Setlocation(pnlOption, lblSize, lblSpeed, lblOpacity, nudSize, nudSpeed, nudOpacity, btnReset);
            t.SpeedLabel = 1;
        }

        #region Kha sửa
        private void nudOpacity_ValueChanged(object sender, EventArgs e)
        {
            k.ReOpacity(this, Convert.ToInt32(nudOpacity.Value.ToString()));
            t.setValueOptionToConfig("-", "-",k.opacity.ToString());
        }

        private void nudSize_ValueChanged(object sender, EventArgs e)
        {
            t.FontSize = k.ReSize(pnlMain, Convert.ToInt32(nudSize.Value.ToString()), this);
            s.SetOptionPanel();
            t.setValueOptionToConfig(t.FontSize.ToString(), "-", "-");
            k.Setlocation(pnlOption, lblSize, lblSpeed, lblOpacity, nudSize, nudSpeed, nudOpacity, btnReset);
        }

        private void nudSpeed_ValueChanged(object sender, EventArgs e)
        {
            t.SpeedLabel = Convert.ToInt32(nudSpeed.Value.ToString());
            t.setValueOptionToConfig("-", t.SpeedLabel.ToString(),"-");
        }
        #endregion

        #region các nút mà Tuân sử dụng
        private void lblTitle_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                t.NextNews_Click();
                nudSpeed.Value = 1;
            }
            
        }

        private void lblCat_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                t.NextRSS_Click();
                nudSpeed.Value = 1;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            t.setDeafault(nudSize,nudSpeed,nudOpacity);
        }

        private void cbbNewsName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbNewsName.Visible = false;
            lblTitle.Visible = true;
        }

        private void cbbCatName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbCatName.Visible = false;
            lblCat.Visible = true;
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
