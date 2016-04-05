using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsFeedAppl.Models
{
    public class FeedDetailsModel
    {
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Url { get; set; }
        public string PublishDate { get; set; }
    }
}