using System;
using System.Collections.Generic;
using System.Text;

namespace Quick_View_Newspaper
{
    class RSSInfo
    {
        private string title;
        private string description;
        private string link;
        private string pubDate;
        private string image;

        public RSSInfo()
        {
            title = "";
            description = "";
            link = "";
            pubDate = "";
            image = "";
        }

        #region setget
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string Link
        {
            get { return link; }
            set { link = value; }
        }

        public string PubDate
        {
            get { return pubDate; }
            set { pubDate = value; }
        }

        public string Image
        {
            get { return image; }
            set { image = value; }
        }
        #endregion
    }
}
