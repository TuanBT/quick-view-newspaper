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
        }

        private void picOptOpen_Click(object sender, EventArgs e)
        {
            pnlMain.Visible = false;
            pnlOption.Visible = true;
        }

        private void picOptClose_Click(object sender, EventArgs e)
        {
            pnlMain.Visible = true;
            pnlOption.Visible = false;
        }

        private void picNameNext_Click(object sender, EventArgs e)
        {

        }

        private void picGenNext_Click(object sender, EventArgs e)
        {

        }

        private void picTitleBack_Click(object sender, EventArgs e)
        {

        }

        private void picTitleNext_Click(object sender, EventArgs e)
        {

        }
    }
}
