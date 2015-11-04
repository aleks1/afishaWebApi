using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace afishaWebApi.Models.DataClasses
{
    public class RecentReview
    {
        public string date_published { get; set; }
        public string image_big_path { get; set; }
        public string image_path { get; set; }
        public string image_url { get; set; }
        public string intro { get; set; }
        public string link_id { get; set; }
        public string link_source { get; set; }
        public string material_id { get; set; }
        public string name { get; set; }
        public string section_name { get; set; }
        public string type { get; set; }
    }
}