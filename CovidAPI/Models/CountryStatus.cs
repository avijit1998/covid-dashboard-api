using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CovidAPI.Models
{
    public class CountryStatus
    {

        [Key]
        public int Id { get; set; }

        public string Country { get; set; }

        public DateTime LastUpdate { get; set; }

        public int Cases { get; set; }

        public int Deaths { get; set; }

        public int Recovered { get; set; }

    }
}