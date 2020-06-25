namespace CovidAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changed_column_name : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CountryDatas", "LastUpdate", c => c.DateTime(nullable: false));
            AddColumn("dbo.GrowthRates", "LastUpdate", c => c.DateTime(nullable: false));
            DropColumn("dbo.CountryDatas", "Date");
            DropColumn("dbo.GrowthRates", "Last_Update");
        }
        
        public override void Down()
        {
            AddColumn("dbo.GrowthRates", "Last_Update", c => c.DateTime(nullable: false));
            AddColumn("dbo.CountryDatas", "Date", c => c.DateTime(nullable: false));
            DropColumn("dbo.GrowthRates", "LastUpdate");
            DropColumn("dbo.CountryDatas", "LastUpdate");
        }
    }
}
