namespace LpiCodeTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IsAdministrator : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "IsAdministrator", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "IsAdministrator");
        }
    }
}
