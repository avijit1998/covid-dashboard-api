using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CovidAPI.Models
{
    public class CountryTimeline
    {
        [Key]
        public int Id { get; set; }

        public string CountryCode { get; set; }

        public DateTime LastUpdate { get; set; }

        public int Cases { get; set; }

        public int Deaths { get; set; }

        public int Recovered { get; set; }

    }
}