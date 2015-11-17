using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using afishaWebApi.Models;
using afishaWebApi.Models.DataClasses;

namespace afishaWebApi.Controllers
{
    public class TopMaterialController : ApiController
    {
        // GET api/topmaterial
        public IEnumerable<TopMaterial> Get()
        {
            return Main.getTopMaterials();
        }

        // GET api/topmaterial/5
        public string Get(int id)
        {
            return "value";
        }
    }
}
