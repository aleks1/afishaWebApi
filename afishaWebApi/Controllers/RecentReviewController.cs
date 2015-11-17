using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using afishaWebApi.Models;
using afishaWebApi.Models.DataClasses;

namespace afishaWebApi.Controllers
{
    public class RecentReviewController : ApiController
    {
        // GET api/recentreview
        public IEnumerable<RecentReview> Get()
        {
            return Main.getRecentReviews();
        }

        // GET api/recentreview/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/recentreview
        public void Post([FromBody]string value)
        {
        }

        // PUT api/recentreview/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/recentreview/5
        public void Delete(int id)
        {
        }
    }
}
