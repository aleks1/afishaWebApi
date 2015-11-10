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
    public class CinemaController : ApiController
    {
        // GET api/cinema
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/cinema/5
        public Cinema Get(int id)
        {
            return Main.getCinema(id);
        }

    }
}
