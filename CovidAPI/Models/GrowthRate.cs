using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CovidAPI.Models
{
    public class GrowthRate
    {
        [Key]
        public int Id { get; set; }

        public string Country { get; set; }

        public DateTime LastUpdate { get; set; }

        public int NewCases { get; set; }

        public int NewDeaths { get; set; }
        
        public int NewRecovered { get; set; }

        public float NewCasePercentage { get; set; }

        public float NewDeathPercentage { get; set; }

        public float NewRecoveredPercentage { get; set; }

    }
}