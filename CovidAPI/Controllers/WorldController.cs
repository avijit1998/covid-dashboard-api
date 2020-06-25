using CovidAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CovidAPI.Controllers
{
    public class WorldController : ApiController
    {

        private CovidDbContext db;

        public WorldController()
        {
            db = new CovidDbContext();

        }

        // GET api/world
        public IEnumerable<WorldTimeline> GetWorldData()
        {
            List<WorldTimeline> worldTimelineData = db.WorldTimeLines.ToList();
            return worldTimelineData;
        }

    }
}
