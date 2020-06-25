using CovidAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CovidAPI.Controllers
{
    public class CountriesController : ApiController
    {

        private CovidDbContext db;

        public CountriesController()
        {
            db = new CovidDbContext();
        }

        // GET api/countries
        public IEnumerable<CountryData> GetAll()
        {
            List<CountryData> countriesData = db.CountryData.ToList();
            return countriesData;
        }

        // GET api/countries/id
        public string Get(int id)
        {
            return "value";
        }

    }
}
