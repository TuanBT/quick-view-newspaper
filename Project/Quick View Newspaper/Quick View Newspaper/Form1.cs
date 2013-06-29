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
        Sinh s=new Sinh();
        Tuan t = new Tuan();
        Kha k = new Kha();

        //t.FontSize là biến để điều khiển font chữ chạy tin. Ví dụ: t.FontSize=15;
        //t.SpeedLabel là biến dùng để điều khiển tốc độ chạy tin. Mặc định: t.SpeedLabel=1

        public Form1()
        {
            InitializeComponent();
            k.OpacityMouse(this);
            t.RUN(pnlRun,lblTitle,lblCat);
            this.KeyPreview = true;
        }

        private void picOptOpen_Click(object sender, EventArgs e)
        {
            s.Open(pnlOption,pnlMain);
        }

        private void picOptClose_Click(object sender, EventArgs e)
        {
            s.Close(pnlOption, pnlMain);
        }

        private void nudOpacity_ValueChanged(object sender, EventArgs e)
        {
            k.ReOpacity(this, Convert.ToInt32(nudOpacity.Value.ToString()));
        }

        private void lblTitle_MouseClick(object sender, MouseEventArgs e)
        {
            t.NextNews_Click(lblTitle, lblCat);
        }

        private void lblCat_MouseClick(object sender, MouseEventArgs e)
        {
            t.NextRSS_Click(lblTitle, lblCat);
        }
    }
}
