using NewsFeedAppl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using System.Web.Mvc;
using System.Xml;

namespace NewsFeedAppl.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var feeds = HelperClass.FetchNewsFeeds().Take(5).ToList();
            return View(feeds);
        }
        //private List<FeedDetailsModel> GetNewsFeeds()
        //{

            
        //    List<FeedDetailsModel> feedsList = new List<FeedDetailsModel>();            
        //    foreach (SyndicationItem item in feed.Items)
        //    {
        //        var eachFeed = new FeedDetailsModel
        //        {
        //            Title = item.Title.Text,
        //            Summary = item.Summary.Text,
        //            PublishDate = item.PublishDate.ToString("dd MMMM yyyy"),
        //            Url = item.Id,
        //        };

        //        feedsList.Add(eachFeed);

        //    }

        //    return feedsList;
        //}
    }
}
