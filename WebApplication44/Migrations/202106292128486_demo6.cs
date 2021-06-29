namespace WebApplication44.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class demo6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Flights", "FirstName", c => c.String(nullable: false));
            AddColumn("dbo.Flights", "LastName", c => c.String(nullable: false));
            AddColumn("dbo.Flights", "Email", c => c.String());
            AddColumn("dbo.UserCruises", "FirstName", c => c.String(nullable: false));
            AddColumn("dbo.UserCruises", "LastName", c => c.String(nullable: false));
            AddColumn("dbo.UserTours", "FirstName", c => c.String(nullable: false));
            AddColumn("dbo.UserTours", "LastName", c => c.String(nullable: false));
            DropColumn("dbo.UserCruises", "Ship_Type");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserCruises", "Ship_Type", c => c.String());
            DropColumn("dbo.UserTours", "LastName");
            DropColumn("dbo.UserTours", "FirstName");
            DropColumn("dbo.UserCruises", "LastName");
            DropColumn("dbo.UserCruises", "FirstName");
            DropColumn("dbo.Flights", "Email");
            DropColumn("dbo.Flights", "LastName");
            DropColumn("dbo.Flights", "FirstName");
        }
    }
}
