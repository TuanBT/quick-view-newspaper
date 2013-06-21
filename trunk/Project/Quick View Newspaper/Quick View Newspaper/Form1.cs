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
            this
            s.SetLocationPanel(pnlOption,pnlMain);
            t.print();
        }

        private void picOptOpen_Click(object sender, EventArgs e)
        {
            s.Open(pnlOption,pnlMain);
        }

        private void picOptClose_Click(object sender, EventArgs e)
        {
            s.Close(pnlOption, pnlMain);
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
