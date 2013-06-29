using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Quick_View_Newspaper
{
    internal class RSSRead
    {
        private XmlTextReader rssReader;
        private XmlDocument rssDoc;
        private XmlNode nodeRss;
        private XmlNode nodeChannel;
        private XmlNode nodeItem;

        public List<RSSInfo> GetListRSS(string feed)
        {
            List<RSSInfo> list = new List<RSSInfo>();
            try
            {
                rssReader = new XmlTextReader(feed);
                rssDoc = new XmlDocument();
                rssDoc.Load(rssReader);
            }
            catch
            {
                //RSS không tồn tại
                return null;
            }

            for (int i = 0; i < rssDoc.ChildNodes.Count; i++)
            {
                if (rssDoc.ChildNodes[i].Name == "rss")
                {
                    nodeRss = rssDoc.ChildNodes[i];
                }
            }

            for (int i = 0; i < nodeRss.ChildNodes.Count; i++)
            {
                if (nodeRss.ChildNodes[i].Name == "channel")
                {
                    nodeChannel = nodeRss.ChildNodes[i];
                }
            }

            for (int i = 0; i < nodeChannel.ChildNodes.Count; i++)
            {
                RSSInfo rssInfo = new RSSInfo();
                if (nodeChannel.ChildNodes[i].Name == "item")
                {
                    nodeItem = nodeChannel.ChildNodes[i];

                    var Title = nodeItem["title"];

                    if (Title != null)
                    {
                        rssInfo.Title = Title.InnerText;

                        var Description = nodeItem["description"];
                        if (Description != null) rssInfo.Description = Description.InnerText;

                        var Link = nodeItem["link"];
                        if (Link != null) rssInfo.Link = Link.InnerText;

                        var PubDate = nodeItem["pubDate"];
                        if (PubDate != null) rssInfo.PubDate = PubDate.InnerText;

                        var Image = nodeItem["image"];
                        if (Image != null) rssInfo.Image = Image.InnerText;

                        list.Add(rssInfo);
                    }
                }
            }
            return list;
        }
    }
}