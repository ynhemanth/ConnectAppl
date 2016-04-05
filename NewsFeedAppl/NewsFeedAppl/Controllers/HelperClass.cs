using NewsFeedAppl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using System.Xml;

namespace NewsFeedAppl.Controllers
{
    public static class HelperClass
    {
        public static List<FeedDetailsModel> FetchNewsFeeds()
        {            
            XmlReader reader = XmlReader.Create("http://feeds.bbci.co.uk/news/world/rss.xml");
            SyndicationFeed feeds = SyndicationFeed.Load(reader);
            reader.Close();
            List<FeedDetailsModel> feedsList = new List<FeedDetailsModel>();
            foreach (SyndicationItem item in feeds.Items)
            {
                var eachFeed = new FeedDetailsModel
                {
                    Title = item.Title.Text,
                    Summary = item.Summary.Text,
                    PublishDate = item.PublishDate.ToString("dd MMMM yyyy"),
                    Url = item.Id,
                };

                feedsList.Add(eachFeed);

            }

            return feedsList;
        }

        public static int QueryValue()
        {
            return (HttpContext.Current.Request.QueryString["c"]!=null ? int.Parse(HttpContext.Current.Request.QueryString["c"]) : 0);
        }
    }
}