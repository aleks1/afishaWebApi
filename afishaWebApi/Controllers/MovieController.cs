using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using afishaWebApi.Models.DataClasses;
using afishaWebApi.Models;

namespace afishaWebApi.Controllers
{
    public class MovieController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Movie> Get()
        {
            return Main.getMovies();
        }

        // GET api/<controller>/5
        public MovieDetails Get(int id)
        {
            return Main.getMovie(id);
        }
    }
}