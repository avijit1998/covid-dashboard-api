namespace CovidAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialcreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CountryDatas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Country = c.String(),
                        CountryCode = c.String(),
                        Slug = c.String(),
                        NewConfirmed = c.Int(nullable: false),
                        TotalConfirmed = c.Int(nullable: false),
                        NewDeaths = c.Int(nullable: false),
                        TotalDeaths = c.Int(nullable: false),
                        NewRecovered = c.Int(nullable: false),
                        TotalRecovered = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CountryStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Country = c.String(),
                        LastUpdate = c.DateTime(nullable: false),
                        Cases = c.Int(nullable: false),
                        Deaths = c.Int(nullable: false),
                        Recovered = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CountryTimelines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CountryCode = c.String(),
                        LastUpdate = c.DateTime(nullable: false),
                        Cases = c.Int(nullable: false),
                        Deaths = c.Int(nullable: false),
                        Recovered = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GrowthRates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Country = c.String(),
                        Last_Update = c.DateTime(nullable: false),
                        NewCases = c.Int(nullable: false),
                        NewDeaths = c.Int(nullable: false),
                        NewRecovered = c.Int(nullable: false),
                        NewCasePercentage = c.Single(nullable: false),
                        NewDeathPercentage = c.Single(nullable: false),
                        NewRecoveredPercentage = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WorldTimelines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LastUpdate = c.DateTime(nullable: false),
                        TotalCases = c.Int(nullable: false),
                        TotalDeaths = c.Int(nullable: false),
                        TotalRecovered = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WorldTimelines");
            DropTable("dbo.GrowthRates");
            DropTable("dbo.CountryTimelines");
            DropTable("dbo.CountryStatus");
            DropTable("dbo.CountryDatas");
        }
    }
}
