﻿using System;
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
        public static RootObject getData() {
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString("http://www.afisha.uz/app/");
                RootObject m = JsonConvert.DeserializeObject<RootObject>(json);
                return m;
            }
        }

        public static List<Movie> getMovies() {
            RootObject rootData = Main.getData();
            return rootData.data.movies_afisha;            
        }

        public static MovieDetails getMovie(int movieId) {
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString("http://www.afisha.uz/app/movies/" + movieId);
                MovieDetailsRoot m = JsonConvert.DeserializeObject<MovieDetailsRoot>(json);
                return m.data;
            }
        }
    }
}