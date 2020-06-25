using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CovidAPI.Models
{
    public class WorldTimeline
    {
        [Key]
        public int Id { get; set; }

        public DateTime LastUpdate { get; set; }

        public int TotalCases { get; set; }

        public int TotalDeaths { get; set; }

        public int TotalRecovered { get; set; }
    }
}