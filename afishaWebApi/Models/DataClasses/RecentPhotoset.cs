using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace afishaWebApi.Models.DataClasses
{
    public class RecentPhotoset
    {
        public string code { get; set; }
        public Cover cover { get; set; }
        public string date_event { get; set; }
        public string description { get; set; }
        public string material_id { get; set; }
        public string photographer { get; set; }
        public string photographer_link { get; set; }
        public string photoset { get; set; }
        public string sponsor_logo { get; set; }
        public string status { get; set; }
        public string title { get; set; }
    }
}