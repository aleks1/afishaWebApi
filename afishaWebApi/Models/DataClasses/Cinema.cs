using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace afishaWebApi.Models.DataClasses
{

    public class RestDays
    {
        public string monday { get; set; }
        public string tuesday { get; set; }
        public string wednesday { get; set; }
        public string thursday { get; set; }
        public string friday { get; set; }
        public string saturday { get; set; }
        public string sunday { get; set; }
        
    }

    public class CinemaDetails
    {
        public string address { get; set; }
        public string city { get; set; }
        public string coords { get; set; }
        public string description { get; set; }
        public string dinner_from { get; set; }
        public string dinner_to { get; set; }
        public string district { get; set; }
        public string email { get; set; }
        public string guides { get; set; }
        public string image_big_path { get; set; }
        public string image_small_path { get; set; }
        public string is_dinner { get; set; }
        public string is_rest { get; set; }
        public string name { get; set; }
        public string num_comments { get; set; }
        public string object_id { get; set; }
        public string phone { get; set; }
        public string phone_code { get; set; }
        public List<object> photos { get; set; }
        public RestDays rest_days { get; set; }
        public string subways { get; set; }
        public List<object> supported_cards { get; set; }
        public string website { get; set; }
        public string work_from { get; set; }
        public string work_to { get; set; }
    }

    public class CinemaMovie
    {
        public string format { get; set; }
        public string genre { get; set; }
        public string movie_id { get; set; }
        public string name { get; set; }
    }

    public class CinemaShow
    {
        public List<CinemaMovie> movie { get; set; }
        public List<string> times { get; set; }
    }

    public class CinemaAfisha
    {
        public string show_date { get; set; }
        public List<CinemaShow> shows { get; set; }
    }

    public class Cinema
    {
        public CinemaDetails cinema { get; set; }
        public List<CinemaAfisha> afisha { get; set; }
    }

    public class CinemaRoot
    {
        public Cinema data { get; set; }
    }
}