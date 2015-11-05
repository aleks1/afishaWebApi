using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace afishaWebApi.Models.DataClasses
{
    public class MovieDetailsRoot {
        public MovieDetails data { get; set; }
    }

    public class Show
    {
        public string cinema_id { get; set; }
        public string cinema { get; set; }
        public List<string> times { get; set; }
        public List<string> formatted_times { get; set; }
        public string format { get; set; }
        public string doubled { get; set; }
        public string first { get; set; }
        public string lang { get; set; }
        public string subtitle_lang { get; set; }
    }

    public class Afisha
    {
        public string show_date { get; set; }
        public List<Show> shows { get; set; }
    }

    public class Comment
    {
        public string avatar { get; set; }
        public string comment { get; set; }
        public string comment_id { get; set; }
        public string date_added { get; set; }
        public string user_name { get; set; }
    }

    public class Photo
    {
        public string image_small_path { get; set; }
        public string image_big_path { get; set; }
    }

    public class Review
    {
        public string material_id { get; set; }
        public string intro { get; set; }
    }

    public class MovieDetails
    {
        public string actors { get; set; }
        public List<Afisha> afisha { get; set; }
        public string alt_name { get; set; }
        public string avg_rate { get; set; }
        public string budget { get; set; }
        public List<Comment> comments { get; set; }
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
        public List<Photo> photos { get; set; }
        public string production { get; set; }
        public string rating { get; set; }
        public string rating_code { get; set; }
        public string rating_notice { get; set; }
        public Review review { get; set; }
        public string trailer_moveruz { get; set; }
        public string url { get; set; }
        public string voices { get; set; }
    }
}