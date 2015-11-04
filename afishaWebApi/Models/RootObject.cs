using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using afishaWebApi.Models.DataClasses;

namespace afishaWebApi.Models
{
    public class RootObject
    {
        public Data data { get; set; }
    }

    public class Data
    {
        public List<Movie> movies_afisha { get; set; }
        public List<TopMaterial> top_materials { get; set; }
        public List<NearestMaterial> nearest_materials { get; set; }
        public List<RecentReview> recent_reviews { get; set; }
        public List<RecentPhotoset> recent_photosets { get; set; }
    }
}