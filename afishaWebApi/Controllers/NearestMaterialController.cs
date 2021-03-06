﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using afishaWebApi.Models;
using afishaWebApi.Models.DataClasses;

namespace afishaWebApi.Controllers
{
    public class NearestMaterialController : ApiController
    {
        // GET api/nearestmaterial
        public IEnumerable<NearestMaterial> Get()
        {
            return Main.getNearestMaterials();
        }

        // GET api/nearestmaterial/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/nearestmaterial
        public void Post([FromBody]string value)
        {
        }

        // PUT api/nearestmaterial/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/nearestmaterial/5
        public void Delete(int id)
        {
        }
    }
}
