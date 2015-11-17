using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using afishaWebApi.Models;
using System.Net;
using Newtonsoft.Json;
using afishaWebApi.Models.DataClasses;

namespace afishaWebApi.Models
{
    public class Main
    {
        public static RootObject data;

        public static void getData() {            
            using (WebClient wc = new WebClient())
            {            
                var json = wc.DownloadString("http://www.afisha.uz/app/");
                RootObject m = JsonConvert.DeserializeObject<RootObject>(json);
                data = m;            
            }
        }

        public static List<Movie> getMovies() {
            return data.data.movies_afisha;            
        }
        public static List<TopMaterial> getTopMaterials() {
            return data.data.top_materials;            
        }
        public static List<NearestMaterial> getNearestMaterials()
        {
            return data.data.nearest_materials;
        }
        public static List<RecentPhotoset> getRecentPhotoSet()
        {
            return data.data.recent_photosets;
        }
        public static List<RecentReview> getRecentReviews()
        {
            return data.data.recent_reviews;
        }

        public static MovieDetails getMovie(int movieId) {
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString("http://www.afisha.uz/app/movies/" + movieId);
                MovieDetailsRoot m = JsonConvert.DeserializeObject<MovieDetailsRoot>(json);
                return m.data;
            }
        }

        public static Cinema getCinema(int cinemaId) {
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString("http://www.afisha.uz/app/cinema/" + cinemaId);
                CinemaRoot m = JsonConvert.DeserializeObject<CinemaRoot>(json);
                return m.data;
            }
        }
    }

}