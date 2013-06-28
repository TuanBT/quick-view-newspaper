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

        public Form1()
        {
            InitializeComponent();
            //k.OpacityMouse(this);
            t.RUN(pnlMain,label1,label2);
        }

        private void picOptOpen_Click(object sender, EventArgs e)
        {
            s.Open(pnlOption,pnlMain);
        }

        private void picOptClose_Click(object sender, EventArgs e)
        {
            s.Close(pnlOption, pnlMain);
        }

        private void picName_MouseClick(object sender, MouseEventArgs e)
        {
            t.NextNews_Click(label1, label2);
        }

        private void picGen_MouseClick(object sender, MouseEventArgs e)
        {
            t.NextRSS_Click(label1, label2);
        }

        private void picTitleBack_Click(object sender, EventArgs e)
        {

        }

        private void picTitleNext_Click(object sender, EventArgs e)
        {

        }

        private void nudOpacity_ValueChanged(object sender, EventArgs e)
        {
            k.ReOpacity(this, Convert.ToInt32(nudOpacity.Value.ToString()));
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
        }




    }
}
