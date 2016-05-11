using _11_TopSpotsAPI.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace _11_TopSpotsAPI.Controllers
{

    [EnableCors(origins: "http://localhost:8080", headers: "*", methods: "*")]

    public class TopSpotsController : ApiController
    {
        public List<TopSpot> spots = new List<TopSpot>();

        // GET: api/TopSpots
        public IEnumerable<TopSpot> Get()
        {
            string json = File.ReadAllText("c:/src/Week 4/11-TopSpotsAPI/11-TopSpotsAPI/11-TopSpotsAPI/App_Data/topspots.json");
            spots = JsonConvert.DeserializeObject<List<TopSpot>>(json);
            return spots;
        }

        // GET: api/TopSpots/5
        public void Get(int id)
        {
        }

        // POST: api/TopSpots
        public TopSpot Post(TopSpot Spot)
        {
            string json = File.ReadAllText("c:/src/Week 4/11-TopSpotsAPI/11-TopSpotsAPI/11-TopSpotsAPI/App_Data/topspots.json");
            spots = JsonConvert.DeserializeObject<List<TopSpot>>(json);

            spots.Add(Spot);

            string NewJson = Newtonsoft.Json.JsonConvert.SerializeObject(spots);
            File.WriteAllText(@"c:/src/Week 4/11-TopSpotsAPI/11-TopSpotsAPI/11-TopSpotsAPI/App_Data/topspots.json", NewJson);

            return Spot;
        }

        // PUT: api/TopSpots/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/TopSpots/5
        public void Delete(int id)
        {
        }
    }
}
