using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using afishaWebApi.Models;

namespace afishaWebApi.Controllers
{
    public class DefaultController : Controller
    {
        //
        // GET: /Default/
        public ViewResult Index()
        {            
            return View(Main.getMovies());
        }
	}
}