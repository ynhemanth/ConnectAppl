using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web;

namespace NewsFeedAppl.Controllers
{   
    public class NewsFeedApiController : ApiController
    {

        public HttpResponseMessage GetMoreNewsFeeds()
        {   
            StringBuilder feedBuilder = new StringBuilder();
            var feedList = HelperClass.FetchNewsFeeds().Skip(5).ToList();
            //int count = (HelperClass.QueryValue()==0 ? 10 : HelperClass.QueryValue());
            //int check = 5;
            foreach (var feeditem in feedList)
            {
                //if(check>=count)
                //{
                //    break;
                //}
                //else
                //{
                    feedBuilder.Append("<div class='col-md-12'><p class='pull-right'>" + feeditem.PublishDate + "</p><h2>" + feeditem.Title + "</h2><p>" + feeditem.Summary + "</p><p><a class='btn btn-default' href='" + feeditem.Url + "' target='_blank'>Read more...</a></p></div>");
                    //check++;
                //}
            }
           
            return new HttpResponseMessage() { Content = new StringContent(feedBuilder.ToString(),Encoding.UTF8,"text/html") };
        }

        
        
    }
}
