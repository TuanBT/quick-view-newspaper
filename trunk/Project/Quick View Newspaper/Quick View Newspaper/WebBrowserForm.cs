using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Quick_View_Newspaper
{
    public partial class WebBrowserForm : Form
    {
        public WebBrowserForm(string Url, string newsName, string CatName)
        {
            InitializeComponent();
            this.Text = newsName + " - " + CatName;
            wbs.ScriptErrorsSuppressed = true;
            this.toolStripStatusLabel1.Text = "Done";
            SetWebBrowser();
            wbs.Navigate(Url);
        }

        private void SetWebBrowser()
        {
            wbs.ProgressChanged += new WebBrowserProgressChangedEventHandler(WebBrowserForm_ProgressChanged);
            wbs.Navigating += new WebBrowserNavigatingEventHandler(WebBrowserForm_Navigating);
            wbs.CanGoBackChanged += new EventHandler(browser_CanGoBackChanged);
            wbs.CanGoForwardChanged += new EventHandler(browser_CanGoForwardChanged);
            wbs.StatusTextChanged += new EventHandler(WebBrowserForm_StatusTextChanged);

        }

        //Show link hover
        void WebBrowserForm_StatusTextChanged(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = ((WebBrowser)sender).StatusText;
        }


        //Navigating
        private void WebBrowserForm_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            this.toolStripStatusLabel1.Text = wbs.StatusText;

        }

        //ProgressChanged    
        private void WebBrowserForm_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            if (e.CurrentProgress < e.MaximumProgress)
                toolStripProgressBar1.Value = (int)e.CurrentProgress;
            else toolStripProgressBar1.Value = toolStripProgressBar1.Minimum;
        }

        //canGoForwardChanged
        void browser_CanGoForwardChanged(object sender, EventArgs e)
        {
            tsbForward.Enabled = !tsbForward.Enabled;
        }
        //canGoBackChanged
        void browser_CanGoBackChanged(object sender, EventArgs e)
        {
            tsbBack.Enabled = !tsbBack.Enabled;
        }

        private void tsbBack_Click(object sender, EventArgs e)
        {
            wbs.GoBack();
        }

        private void tsbForward_Click(object sender, EventArgs e)
        {
            wbs.GoForward();
        }


        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            wbs.Refresh();
        }

        private void tsbStop_Click(object sender, EventArgs e)
        {
            wbs.Stop();
        }


    }
}
