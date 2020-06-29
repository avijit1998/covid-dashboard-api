using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CovidAPI.Models
{
    public class CountryDetails
    {
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public int NewCases { get; set; }
        public int NewDeaths { get; set; }
        public int NewRecovered { get; set; }
        public int TotalCases { get; set; }
        public int TotalDeaths { get; set; }
        public int TotalRecovered { get; set; }
        public float NewCasePercentage { get; set; }
        public float NewDeathPercentage { get; set; }
        public float NewRecoveredPercentage { get; set; }
        public DateTime LastUpdate { get; set; }
        public List<CountryTimeline> countryTimelineData { get; set; }

    }
}