using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace afishaWebApi.Models.DataClasses
{
    public class MovieDetailsRoot {
        public MovieDetails data { get; set; }
    }

    public class MovieDetails
    {
        public string actors { get; set; }
        public List<object> afisha { get; set; }
        public string alt_name { get; set; }
        public string avg_rate { get; set; }
        public string budget { get; set; }
        public List<object> comments { get; set; }
        public string country { get; set; }
        public string date_premiere { get; set; }
        public string description { get; set; }
        public string director { get; set; }
        public string duration { get; set; }
        public string format { get; set; }
        public string genre { get; set; }
        public string image_big_path { get; set; }
        public string image_path { get; set; }
        public string image_small_path { get; set; }
        public string imdb_rating { get; set; }
        public string is_recommended { get; set; }
        public string movie_id { get; set; }
        public string mpaa_rating_code { get; set; }
        public string mpaa_rating_notice { get; set; }
        public string name { get; set; }
        public string original { get; set; }
        public string permalink { get; set; }
        public List<object> photos { get; set; }
        public string production { get; set; }
        public string rating { get; set; }
        public string rating_code { get; set; }
        public string rating_notice { get; set; }
        public Review review { get; set; }
        public string trailer_moveruz { get; set; }
        public string url { get; set; }
        public string voices { get; set; }
    }

    public class Review
    {
        public string material_id { get; set; }
        public string intro { get; set; }
    }
}