namespace LpiCodeTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String());
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String());
            AddColumn("dbo.AspNetUsers", "DriversLicenseNumber", c => c.String());
            AddColumn("dbo.AspNetUsers", "CarMake", c => c.String());
            AddColumn("dbo.AspNetUsers", "CarModel", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "CarModel");
            DropColumn("dbo.AspNetUsers", "CarMake");
            DropColumn("dbo.AspNetUsers", "DriversLicenseNumber");
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "FirstName");
        }
    }
}
