using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CovidAPI.Models
{
    public class CovidDbContext : DbContext
    {
        public DbSet<CountryData> CountryData { get; set; }
        public DbSet<CountryStatus> CountryStatus { get; set; }
        public DbSet<CountryTimeline> CountryTimeLines { get; set; }
        public virtual DbSet<GrowthRate> GrowthRates { get; set; }
        public virtual DbSet<WorldTimeline> WorldTimeLines { get; set; } 

        
    }
}