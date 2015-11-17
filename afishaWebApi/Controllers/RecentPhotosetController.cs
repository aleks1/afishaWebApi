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
    public class RecentPhotosetController : ApiController
    {
        // GET api/recentphotoset
        public IEnumerable<RecentPhotoset> Get()
        {
            return Main.getRecentPhotoSet();
        }

        // GET api/recentphotoset/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/recentphotoset
        public void Post([FromBody]string value)
        {
        }

        // PUT api/recentphotoset/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/recentphotoset/5
        public void Delete(int id)
        {
        }
    }
}
