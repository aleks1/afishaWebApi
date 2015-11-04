using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace afishaWebApi.Models.DataClasses
{
    public class Movie
    {
        public string country { get; set; }
        public DateTime date_premiere { get; set; }
        public string duration { get; set; }
        public string format { get; set; }
        public string genre { get; set; }
        public string image_url { get; set; }
        public int movie_id { get; set; }
        public string name { get; set; }
        public string original { get; set; }
    }
}