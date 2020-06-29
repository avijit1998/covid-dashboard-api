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

        // GET api/countries/slug
        public CountryDetails Get(string slug)
        {
            CountryDetails countryDetailsObj = new CountryDetails();

            var countryData = db.CountryData.FirstOrDefault(c=> c.Slug == slug);
            
            countryDetailsObj.CountryCode = countryData.CountryCode;
            countryDetailsObj.Name = countryData.Country;
            countryDetailsObj.LastUpdate = countryData.LastUpdate;
            countryDetailsObj.NewCases = countryData.NewConfirmed;
            countryDetailsObj.NewDeaths = countryData.NewDeaths;
            countryDetailsObj.NewRecovered = countryData.NewRecovered;
            countryDetailsObj.TotalCases = countryData.TotalConfirmed;
            countryDetailsObj.TotalDeaths = countryData.TotalDeaths;
            countryDetailsObj.TotalRecovered = countryData.TotalRecovered;

            var growthRate = db.GrowthRates.FirstOrDefault(c => c.Country == countryDetailsObj.CountryCode);

            countryDetailsObj.NewCasePercentage = growthRate.NewCasePercentage;
            countryDetailsObj.NewDeathPercentage = growthRate.NewDeathPercentage;
            countryDetailsObj.NewRecoveredPercentage = growthRate.NewRecoveredPercentage;

            countryDetailsObj.countryTimelineData = db.CountryTimeLines.Where(c => c.CountryCode == countryDetailsObj.CountryCode).ToList();

            return countryDetailsObj;
        }

    }
}
