namespace WebApplication44.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class demo1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AdminFlights", "Departure_Date", c => c.String());
            AlterColumn("dbo.Cruises", "DepartureTime", c => c.String());
            AlterColumn("dbo.Flights", "DepartureTime", c => c.String());
            AlterColumn("dbo.Flights", "Return_Time", c => c.String());
            AlterColumn("dbo.Tours", "Tour_Time", c => c.String());
            AlterColumn("dbo.UserCruises", "Departure_Date", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserCruises", "Departure_Date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Tours", "Tour_Time", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Flights", "Return_Time", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Flights", "DepartureTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Cruises", "DepartureTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.AdminFlights", "Departure_Date", c => c.DateTime(nullable: false));
        }
    }
}
